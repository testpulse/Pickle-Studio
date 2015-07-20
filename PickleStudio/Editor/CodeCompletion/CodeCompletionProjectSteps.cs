using PickleStudio.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PickleStudio.Editor.CodeCompletion
{
    public class CodeCompletionProjectSteps
    {
        private readonly Dictionary<Feature, CodeCompletionFeatureSteps> _steps = new Dictionary<Feature, CodeCompletionFeatureSteps>();

        private Lazy<List<string>> _givens;
        private Lazy<List<string>> _whens;
        private Lazy<List<string>> _thens;

        public List<string> Givens { get { return _givens.Value; } }
        public List<string> Whens { get { return _whens.Value; } }
        public List<string> Thens { get { return _thens.Value; } }

        public CodeCompletionProjectSteps()
        {
            Invalidate();
        }

        public void ClearSteps()
        {
            _steps.Clear();
            Invalidate();
        }

        public void RefreshSteps(Feature feature)
        {
            _steps[feature] = new CodeCompletionFeatureSteps(feature);
            Invalidate();
        }

        private void Invalidate()
        {
            if (_givens == null || _givens.IsValueCreated) _givens = new Lazy<List<string>>(GetGivens);
            if (_whens == null || _whens.IsValueCreated) _whens = new Lazy<List<string>>(GetWhens);
            if (_thens == null || _thens.IsValueCreated) _thens = new Lazy<List<string>>(GetThens);
        }

        private List<string> GetGivens()
        {
            return _steps.Values.SelectMany(f => f.Givens).Distinct().ToList();
        }

        private List<string> GetThens()
        {
            return _steps.Values.SelectMany(f => f.Thens).Distinct().ToList();
        }

        private List<string> GetWhens()
        {
            return _steps.Values.SelectMany(f => f.Whens).Distinct().ToList();
        }
    }
}
