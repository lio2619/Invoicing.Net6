namespace invoicing.CommonFunction
{
    internal class CallFormFunction
    {
        private readonly Form _childForm;
        private readonly Form _parentForm;
        public CallFormFunction(Form childForm, Form parentForm) 
        {
            _childForm = childForm;
            _parentForm = parentForm;
        }
        public void OpenForm()
        {
            //防止視窗重複開啟
            foreach(Form form in _parentForm.MdiChildren)
            {
                if(form.Name == _childForm.Name)
                {
                    form.Focus();
                    return;
                }
            }
            _childForm.MdiParent = _parentForm;
            _childForm.Show();
        }
        /// <summary>
        /// 開啟模糊搜尋、讀取單子視窗
        /// </summary>
        public void OpenOtherForm()
        {
            _childForm.Owner = _parentForm;
            _childForm.Show();
        }
    }
}
