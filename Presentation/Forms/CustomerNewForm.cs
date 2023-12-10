﻿using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Patterns;

namespace Presentation.Forms
{
    public partial class CustomerNewForm : Form
    {
        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();
        public CustomerNewForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            CustomerDTO customer = new CustomerDTO();
            customer.FullName = FullNameTxt.Text;
            customer.Title = TitleTxt.Text;
            customer.Description = DescriptionTxt.Text;
            customer.Key = Guid.NewGuid();
            _unitOfWork.CustomerService.Insert(customer);
            _unitOfWork.CustomerService.Save();
            MSG.Visible = true;
            MSG.Text = "عملیات با موفقیت انجام شد";
            this.Close();
        }

        
    }
}