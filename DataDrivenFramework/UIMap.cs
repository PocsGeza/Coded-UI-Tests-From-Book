using System.Windows.Forms;
using mshtml;

namespace DataDrivenFramework
{
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class UIMap
    {

        /// <summary>
        /// action recordeing
        /// </summary>
        public void Login()
        {
            #region Variable Declarations

            HtmlComboBox sainityCheckLocation = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomSearchHoteDocument.UILocationComboBox;
            WinButton uICloseButton = this.UIMSNcomHotmailOutlookWindow.UIMSNcomHotmailOutlookTitleBar.UICloseButton;
            HtmlInputButton uIReset = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomSelectHoteDocument.UIContinueButton;
            HtmlEdit uIUsernameEdit = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomHotelReserDocument.UIUsernameEdit;
            HtmlEdit uIPasswordEdit = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomHotelReserDocument.UIPasswordEdit;
            HtmlInputButton uILoginButton = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomHotelReserDocument.UILoginButton;
            #endregion

            #region
            // Go to web page 'http://adactin.com/hotelapp' using new browser instance
            this.UIMSNcomHotmailOutlookWindow.LaunchUrl(new System.Uri(this.LoginParams.UIMSNcomHotmailOutlookWindowUrl1));

            // Type 'pocsgeza' in 'username' text box
            uIUsernameEdit.Text = this.LoginParams.UIUsernameEditText;

            // Type '********' in 'password' text box
            uIPasswordEdit.Password = this.LoginParams.UIPasswordEditPassword;

            // Click 'Login' button
            Mouse.Click(uILoginButton, new Point(41, 19));
            #endregion

            //Wait for Login to process

            //If I use uiReset insted of sainityCheckLocation the If block will give the oposite result
            //both are on the same page and appear at the same time
            sainityCheckLocation.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            if (sainityCheckLocation.WaitForControlExist(10000))
            {
                Console.WriteLine("Login succesfull");
            }
            else
            {
                Console.WriteLine("1111 Time out occured- Login failed");
                Mouse.Click(uICloseButton, new Point(29, 13));
            }
        }

        public virtual LoginParams LoginParams
        {
            get
            {
                if ((this.mLoginParams == null))
                {
                    this.mLoginParams = new LoginParams();
                }
                return this.mLoginParams;
            }
        }

        private LoginParams mLoginParams;

        /// <summary>
        /// Booking - Use 'BookingParams' to pass parameters into this method.
        /// </summary>
        public void Booking()
        {
            #region Variable Declarations

            HtmlEdit uI_HoteName = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomBookAHotelDocument.UIHotel_name_disEdit;
            HtmlEdit uI_OrderNo = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomHotelBookiDocument.UIOrder_noEdit;
            HtmlComboBox uILocationComboBox = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomSearchHoteDocument.UILocationComboBox;
            HtmlComboBox uIRoom_nosComboBox = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomSearchHoteDocument.UIRoom_nosComboBox;
            HtmlComboBox uIAdult_roomComboBox = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomSearchHoteDocument.UIAdult_roomComboBox;
            HtmlInputButton uISearchButton = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomSearchHoteDocument.UISearchButton;
            HtmlRadioButton uIRadiobutton_2RadioButton = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomSelectHoteDocument.UIRadiobutton_2RadioButton;
            HtmlInputButton uIContinueButton = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomSelectHoteDocument.UIContinueButton;
            HtmlEdit uIFirst_nameEdit = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomBookAHotelDocument.UIFirst_nameEdit;
            HtmlEdit uILast_nameEdit = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomBookAHotelDocument.UILast_nameEdit;
            HtmlTextArea uIAddressEdit = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomBookAHotelDocument.UIAddressEdit;
            HtmlEdit uICc_numEdit = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomBookAHotelDocument.UICc_numEdit;
            HtmlComboBox uICc_typeComboBox = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomBookAHotelDocument.UICc_typeComboBox;
            HtmlComboBox uICc_exp_monthComboBox = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomBookAHotelDocument.UICc_exp_monthComboBox;
            HtmlCell uISelectMonthJanuaryFeCell = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomBookAHotelDocument.UIBook_hotel_formCustom.UIItemTable.UISelectMonthJanuaryFeCell;
            HtmlComboBox uICc_exp_yearComboBox = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomBookAHotelDocument.UICc_exp_yearComboBox;
            HtmlEdit uICc_cvvEdit = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomBookAHotelDocument.UICc_cvvEdit;
            HtmlInputButton uIBookNowButton = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomBookAHotelDocument.UIBookNowButton;
            HtmlHyperlink uILogoutHyperlink = this.UIMSNcomHotmailOutlookWindow.UIAdactIncomHotelBookiDocument.UILogoutHyperlink;
            WinButton uICloseButton = this.UIMSNcomHotmailOutlookWindow.UIMSNcomHotmailOutlookTitleBar.UICloseButton;
            #endregion

            // Select 'Sydney' in 'location' combo box
            uILocationComboBox.SelectedItem = this.BookingParams.UILocationComboBoxSelectedItem;

            // Select '2 - Two' in 'room_nos' combo box
            uIRoom_nosComboBox.SelectedItem = this.BookingParams.UIRoom_nosComboBoxSelectedItem;

            // Select '2 - Two' in 'adult_room' combo box
            uIAdult_roomComboBox.SelectedItem = this.BookingParams.UIAdult_roomComboBoxSelectedItem;

            // Click 'Search' button
            Mouse.Click(uISearchButton, new Point(29, 11));

            // Check if citize are displayed
            uIRadiobutton_2RadioButton.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            if (uIRadiobutton_2RadioButton.WaitForControlExist(10000))
            {
                Console.WriteLine("City lisr appeared");
            }
            else
            {
                Console.WriteLine("Time out occured- Hotel list did not appear in time");
            }

            //  Select 'radiobutton_2' radio button
            uIRadiobutton_2RadioButton.Selected = this.BookingParams.UIRadiobutton_2RadioButtonSelected;

            // Click 'Continue' button
            Mouse.Click(uIContinueButton, new Point(47, 10));

            // Wait reservation form
            uI_HoteName.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            if (uI_HoteName.WaitForControlExist(10000))
            {
                Console.WriteLine(uI_HoteName.Text);
            }
            else
            {
                Console.WriteLine("Time out occured- Reservation failed");
            }

            //Type 'pocs' in 'first_name' text box
            uIFirst_nameEdit.Text = this.BookingParams.UIFirst_nameEditText;

            // Type 'geza' in 'last_name' text box
            uILast_nameEdit.Text = this.BookingParams.UILast_nameEditText;

            // Type 'sdfghjkrtyuio' in 'address' text box
            uIAddressEdit.Text = this.BookingParams.UIAddressEditText;

            // Type '1111111111111122' in 'cc_num' text box
            uICc_numEdit.Text = this.BookingParams.UICc_numEditText;

            // Select 'VISA' in 'cc_type' combo box
            uICc_typeComboBox.SelectedItem = this.BookingParams.UICc_typeComboBoxSelectedItem;

            // Select 'April' in 'cc_exp_month' combo box
            uICc_exp_monthComboBox.SelectedItem = this.BookingParams.UICc_exp_monthComboBoxSelectedItem;

            // Click '- Select Month - January February March' cell
            Mouse.Click(uISelectMonthJanuaryFeCell, new Point(262, 13));

            // Select '2022' in 'cc_exp_year' combo box
            uICc_exp_yearComboBox.SelectedItem = this.BookingParams.UICc_exp_yearComboBoxSelectedItem;

            // Type '333' in 'cc_cvv' text box
            uICc_cvvEdit.Text = this.BookingParams.UICc_cvvEditText;

            // Click 'Book Now' button
            Mouse.Click(uIBookNowButton, new Point(34, 14));

            // Wait for 5 seconds for user delay between actions; Click 'Logout' link
            //Playback.Wait(5000);

            uI_OrderNo.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            if (uI_OrderNo.WaitForControlExist(10000))
            {
                Console.WriteLine(uI_OrderNo.Text);
                Mouse.Click(uILogoutHyperlink, new Point(30, 13));
            }
            else                                                  
            {
                Console.WriteLine("Time out occured- Booking failed");
            }

            //Click 'Logout' link
           // Mouse.Click(uILogoutHyperlink, new Point(29, 7));

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(29, 13));
        }

        public virtual BookingParams BookingParams
        {
            get
            {
                if ((this.mBookingParams == null))
                {
                    this.mBookingParams = new BookingParams();
                }
                return this.mBookingParams;
            }
        }

        private BookingParams mBookingParams;
    }
    /// <summary>
    /// Parameters to be passed into 'Login'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class LoginParams
    {

        #region Fields
        /// <summary>
        /// Go to web page 'http://go.microsoft.com/fwlink/p/?LinkId=255141' using new browser instance
        /// </summary>
        public string UIMSNcomHotmailOutlookWindowUrl = "http://go.microsoft.com/fwlink/p/?LinkId=255141";

        /// <summary>
        /// Go to web page 'http://adactin.com/hotelapp' using new browser instance
        /// </summary>
        public string UIMSNcomHotmailOutlookWindowUrl1 = "http://adactin.com/hotelapp";

        /// <summary>
        /// Type 'pocsgeza' in 'username' text box
        /// </summary>
        public string UIUsernameEditText = "pocsgeza";

        /// <summary>
        /// Type '********' in 'password' text box
        /// </summary>
        public string UIPasswordEditPassword = "S8wpb/tN6fMCerm5H245EaqwBjgfnHu4";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'Booking'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class BookingParams
    {

        #region Fields
        /// <summary>
        /// Select 'Sydney' in 'location' combo box
        /// </summary>
        public string UILocationComboBoxSelectedItem = "Sydney";

        /// <summary>
        /// Select '2 - Two' in 'room_nos' combo box
        /// </summary>
        public string UIRoom_nosComboBoxSelectedItem = "2 - Two";

        /// <summary>
        /// Select '2 - Two' in 'adult_room' combo box
        /// </summary>
        public string UIAdult_roomComboBoxSelectedItem = "2 - Two";

        /// <summary>
        /// Wait for 5 seconds for user delay between actions; Select 'radiobutton_2' radio button
        /// </summary>
        public bool UIRadiobutton_2RadioButtonSelected = true;

        /// <summary>
        /// Wait for 5 seconds for user delay between actions; Type 'pocs' in 'first_name' text box
        /// </summary>
        public string UIFirst_nameEditText = "pocs";

        /// <summary>
        /// Type 'geza' in 'last_name' text box
        /// </summary>
        public string UILast_nameEditText = "geza";

        /// <summary>
        /// Type 'sdfghjkrtyuio' in 'address' text box
        /// </summary>
        public string UIAddressEditText = "sdfghjkrtyuio";

        /// <summary>
        /// Type '1111111111111122' in 'cc_num' text box
        /// </summary>
        public string UICc_numEditText = "1111111111111122";

        /// <summary>
        /// Select 'VISA' in 'cc_type' combo box
        /// </summary>
        public string UICc_typeComboBoxSelectedItem = "VISA";

        /// <summary>
        /// Select 'April' in 'cc_exp_month' combo box
        /// </summary>
        public string UICc_exp_monthComboBoxSelectedItem = "April";

        /// <summary>
        /// Select '2022' in 'cc_exp_year' combo box
        /// </summary>
        public string UICc_exp_yearComboBoxSelectedItem = "2022";

        /// <summary>
        /// Type '333' in 'cc_cvv' text box
        /// </summary>
        public string UICc_cvvEditText = "333";
        #endregion
    }
}
