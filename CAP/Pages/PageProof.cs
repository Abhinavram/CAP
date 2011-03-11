﻿using UpdateControls;

namespace CAP.Pages
{
    public class PageProof : Page
    {
        private string[] _states =
        {
            "Begin",
            "WriteFirst",
            "ReadSecond",
            "Partitioned",
            "NotConsistent",
            "NotAvailable",
            "NotPartitionTolerant"
        };
        private int _currentStateIndex = 0;

        public PageProof(PresentationNavigationModel presentationNavigation)
            : base(presentationNavigation, "Proof", "Proof")
        {
        }

        #region Independent properties
        // Generated by Update Controls --------------------------------
        private Independent _indCurrentStateIndex = new Independent();

        public int CurrentStateIndex
        {
            get { _indCurrentStateIndex.OnGet(); return _currentStateIndex; }
            set { _indCurrentStateIndex.OnSet(); _currentStateIndex = value; }
        }
        // End generated code --------------------------------
        #endregion

        public override string CurrentState
        {
            get { return _states[CurrentStateIndex]; }
        }

        public override void ChangeState(int offset)
        {
            int newStateIndex = CurrentStateIndex + offset;
            if (0 <= newStateIndex && newStateIndex < _states.Length)
                CurrentStateIndex = newStateIndex;
        }
    }
}