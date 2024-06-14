namespace WinFormsApplication.Services.Impl
{
    public class VerificationContext
    {
        private readonly List<Validation> _validations;

        public VerificationContext()
        {
            _validations = new();
        }

        public void CreateValidation(Control control, Label label, Func<bool> predicate)
        {
            _validations.Add(new()
            {
                Control = control,
                Label = label,
                Expr = predicate,
            });

            control.TextChanged += (s, e) => SetDefault(control, label);
        }

        public bool Verify()
        {
            var result = true;

            foreach (var validation in _validations)
            {
                if (Validate(validation.Expr, validation.Control, validation.Label) == false)
                {
                    result = false;
                }
            }

            return result;
        }

        private void SetInvalid(Control control, Label label)
        {
            control.ForeColor = Color.Red;

            label.ForeColor = Color.Red;
        }

        private void SetValid(Control control, Label label)
        {
            control.ForeColor = Color.Green;

            label.ForeColor = Color.Green;
        }

        private bool Validate(Func<bool> condition, Control control, Label label)
        {
            var result = condition();

            if (result)
            {
                SetValid(control, label);
            }
            else
            {
                SetInvalid(control, label);
            }

            return result;
        }

        private void SetDefault(Control control, Label label)
        {
            control.ForeColor = Color.Black;

            label.ForeColor = Color.Black;
        }

        public class Validation
        {
            public Control Control { get; set; }

            public Label Label { get; set; }

            public Func<bool> Expr { get; set; }
        }
    }
}
