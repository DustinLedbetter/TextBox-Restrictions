/***********************************************************************************************************************************
*                                                 GOD First                                                                        *
* Author: Dustin Ledbetter                                                                                                         *
* Release Date: 10-26-2018                                                                                                         *
* Version: 1.0                                                                                                                     *
* Purpose: Snippets of code to restrict chars being added to a text box                                                            *
************************************************************************************************************************************/

// Method 1: (Only allows letters to be entered)

  // This is used to hold our current string as it is built and for testing the new char
  string oldText = string.Empty;

  // This method Only allows letters to be entered into the textbox
  private void UserNameTextBox_TextChanged(object sender, EventArgs e)
  {
      if (UserNameTextBox.Text.(chr => char.IsLetter(chr)))
      {
          oldText = UserNameTextBox.Text;
          UserNameTextBox.Text = oldText;

          UserNameTextBox.BackColor = System.Drawing.Color.White;
          UserNameTextBox.ForeColor = System.Drawing.Color.Black;
      }
      else
      {
          UserNameTextBox.Text = oldText;
          UserNameTextBox.BackColor = System.Drawing.Color.Red;
          UserNameTextBox.ForeColor = System.Drawing.Color.White;
      }
      UserNameTextBox.SelectionStart = UserNameTextBox.Text.Length;
  }


// Method 2: (Only allows number to be entered)

  // This is used to hold our current string as it is built and for testing the new char
  string oldText = string.Empty;

  // This method Only allows numbers to be entered into the textbox
  private void UserNameTextBox_TextChanged(object sender, EventArgs e)
  {
      if (UserNameTextBox.Text.Any(chr => char.IsNumber(chr)))
      {
          oldText = UserNameTextBox.Text;
          UserNameTextBox.Text = oldText;

          UserNameTextBox.BackColor = System.Drawing.Color.White;
          UserNameTextBox.ForeColor = System.Drawing.Color.Black;
      }
      else
      {
          UserNameTextBox.Text = oldText;
          UserNameTextBox.BackColor = System.Drawing.Color.Red;
          UserNameTextBox.ForeColor = System.Drawing.Color.White;
      }
      UserNameTextBox.SelectionStart = UserNameTextBox.Text.Length;
  }
  
  
// Method 3: (allows only letters OR numbers to be entered)
  
  // This is called anytime the user tries to add or remove a char from the username textbox
  private void UserNameTextBox_TextChanged(object sender, EventArgs e)
  {
      // This is used to only allow the user to input letters or characters into the textbox
      UserNameTextBox.Text = string.Concat(UserNameTextBox.Text.Where(char.IsLetterOrDigit));

      // This is used to set the next char entry to be at the end of our current entry 
      UserNameTextBox.SelectionStart = UserNameTextBox.Text.Length + 1;
  }