using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Elevators
{
    public partial class Form1 : Form
    {
      //  private DataRow targetRow;
        private bool filled = false;
        public DataSet ds = new DataSet();

       

        public Form1()
        {
            InitializeComponent();

        }
        private void lift_data (object sender, EventArgs e)
        {
 
        }
        private void databaseInsert( object sender, EventArgs e)
        {


        }

        //Creating a method name insertFirstFloor that inserts data into acces when floor 1 button is pressed. This also reduces the volume of the code
        private void insertFirstFloor()
        {
            //Creating a Database Connection String and locating the access database file
            string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source =LiftData.accdb";
            string dbcommand = "Select LiftFloor, Doors, DateLift,TimeLift from Lift_Data;";
            //Creating a new database Connection
            OleDbConnection conn = new OleDbConnection(dbconnection);
            OleDbCommand comm = new OleDbCommand(dbcommand, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(comm);

            conn.Open();

            conn.Close();

            //Executing the queries in the try-catch blocks to handle exceptions
            try
            {
                //Opening the connection
                conn.Open();
                // Defining variables such as liftfloor,doors and date and time variables to get the exact time when the buttons are pressed
                String LiftFloor1 = "Lift on Floor 1";
                String Doors1 = "Doors Closed";
                DateTime now = DateTime.Now;
                //Converting the date and time to string so that it could be inserted into the database
                String Time1 = now.ToString("HH:mm:ss:  tt");
                String Date1 = DateTime.Today.ToString("dd/MM/yyyy");
                // Preparing the query to insert data into the database which uses variables defined above
                String my_querry = "INSERT INTO Lift_Data(LiftFloor,Doors,DateLift,TimeLift)VALUES('" + LiftFloor1 + "','" + Doors1 + "','" + Date1 + "','" + Time1 + "');";


                //Executing the insert query prepared above
                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
                
              //Showing message that the data has been transferred succesfully
                label2.Text = "Data saved successfuly...!";
            }

            //Catching any type of exceptions that may occur
            catch (Exception ex)
            {
                label2.Text = "Failed due to" + ex.Message;
            }
            finally
            {
                //Closing the connection
                conn.Close();
            }


        }
        //Creating a method name insertGroundFloor that inserts data into acces when floor G button is pressed. This also reduces the volume of the code
        private void insertGroundFloor()
        {
            //Creating a Database Connection String and locating the access database file
            string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source =LiftData.accdb";
            string dbcommand = "Select LiftFloor, Doors, DateLift,TimeLift from Lift_Data;";
            //Creating a new database Connection
            OleDbConnection conn = new OleDbConnection(dbconnection);
            OleDbCommand comm = new OleDbCommand(dbcommand, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(comm);

            conn.Open();

            conn.Close();
            
            //Executing the queries in the try-catch blocks to handle exceptions
            try
            {
                //Opening the connection
                conn.Open();
                // Defining variables such as liftfloor,doors and date and time variables to get the exact time when the buttons are pressed
                String LiftFloor1 = "Lift on Floor 0";
                String Doors1 = "Doors Closed";
                DateTime now = DateTime.Now;

                //Converting the date and time to string so that it could be inserted into the database
                String Time1 = now.ToString("HH:mm:ss:  tt");
                String Date1 = DateTime.Today.ToString("dd/MM/yyyy");
                 // Preparing the query to insert data into the database which uses variables defined above
                String my_querry = "INSERT INTO Lift_Data(LiftFloor,Doors,DateLift,TimeLift)VALUES('" + LiftFloor1 + "','" + Doors1 + "','" + Date1 + "','" + Time1 + "');";


                //Executing the insert query prepared above
                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
                //Showing message in a label that the data has been transferred
                label2.Text = "Data saved successfuly...!";
            }

            //This block catches any type of exceptions that may occur 
            catch (Exception ex)
            {
                label2.Text = "Failed due to" + ex.Message;
            }
            finally
            {
                //Closing the database connection
                conn.Close();
            }

          }
        //Creating this method to insert data into database when doors are closed to reduce volume of code 
        private void insertDoorsOpenFloor1()
        {
            //Creating a dbconnection String and locating the access database file
            string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source =LiftData.accdb";
            string dbcommand = "Select LiftFloor, Doors, DateLift,TimeLift from Lift_Data;";
            //Creating a new database connection
            OleDbConnection conn = new OleDbConnection(dbconnection);
            OleDbCommand comm = new OleDbCommand(dbcommand, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(comm);

            conn.Open();

            //adapter.Fill(ds, "Lift_Data");

            conn.Close();
        
            //Excecuting the data manipulation queries in the try-catch block to handle exceptions in a better way 
            try
            {
                //Opening the database connection
                conn.Open();
                //Defining variables such as liftfloor,doors,date and time to use with the insert command
                String LiftFloor1 = "Lift on Floor 1";
                String Doors1 = "Doors Open";
                DateTime now = DateTime.Now;
                //Converting the date and time into string so that it could be used in the command
                String Time1 = now.ToString("HH:mm:ss:  tt");
                String Date1 = DateTime.Today.ToString("dd/MM/yyyy");
                //Preparing the inert query to enter data into the database 
                String my_querry = "INSERT INTO Lift_Data(LiftFloor,Doors,DateLift,TimeLift)VALUES('" + LiftFloor1 + "','" + Doors1 + "','" + Date1 + "','" + Time1 + "');";


                //Excecuting the INSERT command prepared above 
                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                label2.Text = "Data saved successfuly...!";
            }
            //Catching exeption that may have occured and showing error message
            catch (Exception ex)
            {
                label2.Text = "Failed due to" + ex.Message;
            }
            finally
            {
                //Closing the database connection
                conn.Close();
            }


        }
        //Creating a method to insert data when doors are opened on ground floor to reduce volume of code 
        private void insertDoorsOpenFloor0()
        {
            //Creating a dbconnection String and locating the Access Database File
            string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source =LiftData.accdb";
            string dbcommand = "Select LiftFloor, Doors, DateLift,TimeLift from Lift_Data;";
            //Creating a new connectin
            OleDbConnection conn = new OleDbConnection(dbconnection);
            OleDbCommand comm = new OleDbCommand(dbcommand, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(comm);

            conn.Open();

            conn.Close();

            //Executing the Data Manipulating command in the try-catch block to handle exceptions
            try
            {
                //Opening the connection
                conn.Open();
                //Defing variables such as liftfloor,doors, time etc to be used with the INSERT Command
                String LiftFloor1 = "Lift on Floor 0";
                String Doors1 = "Doors Open";
                DateTime now = DateTime.Now;
                //Converting the date and time into String 
                String Time1 = now.ToString("HH:mm:ss:  tt");
                String Date1 = DateTime.Today.ToString("dd/MM/yyyy");
                //Creating the INSERT Command to enter data into the database with the variable defined above
                String my_querry = "INSERT INTO Lift_Data(LiftFloor,Doors,DateLift,TimeLift)VALUES('" + LiftFloor1 + "','" + Doors1 + "','" + Date1 + "','" + Time1 + "');";


                //Executing the INSERT command prepared above 
                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                label2.Text = "Data saved successfuly...!";
            }
            //Catching any types of exceptions that may have occured and shwoing error message
            catch (Exception ex)
            {
                label2.Text = "Failed due to" + ex.Message;
            }
            finally
            {
                //Closing the database 
                conn.Close();
            }


        }

        private void ElevatorBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Defining the Location of the Panel(Lift Body) On x-axis and y-axis respectively 
            int x = ElevatorBody.Location.X;
            int y = ElevatorBody.Location.Y;
            int left = left_door.Location.X;
            



           
            //Only moving the elevator downwards when lift if on floor 1 i.e when y-axis=3 and doors must be closed i.e left==14 
            if ((y == 3) && (left==14))
            {
                //This method inserts the data into the database when the button is pressed. This is used to reduce volume of code. Check method above
                insertGroundFloor();
               
                //A for loop that increments the position of the Panel i.e Lift by 300 
                for (int s = 0; s < 300; s++)
                {
                    ElevatorBody.Location = new System.Drawing.Point(ElevatorBody.Location.X, ElevatorBody.Location.Y + 1);
                    //Using Thread.Sleep to make the animation of the lift
                    System.Threading.Thread.Sleep(10);

                    //Setting the labels to the position equivalent to the lift 
                    label4.Text = "G";
                    label5.Text = "G";
                    label3.Text = "";
                    label12.Text = "G";
                 
                  

                }
              

                }
            //If doors are open then display a message to close doors i.e Lift Cant go Down If doors are open
            else if (left==-76 && y==3)
            {
                label3.Font = new Font("Arial", 10, FontStyle.Bold);
                label3.Font = new Font("Arial", 10, FontStyle.Bold);
                label3.Text = "Please Close Door First";
                label3.Text = "Please Close Door First";
            }
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Defing the position of the Panel(Elevator body on x-axis and y-axis to control movements
            int x = ElevatorBody.Location.X;
            int y = ElevatorBody.Location.Y;
            int left = left_door.Location.X;

            //Creating an if statement as to only move the elevator to floor 1 when doors are closed and lift is on Ground floor
            if (y ==303  && left==14) {

                //Calling this method which enters data into database accordingly. Please check full method code above
                insertFirstFloor();

                //A for loop that keeps on incrementing the position of the Lift(Panel) by 300
                for (int s = 0; s < 300; s++)
                {
                   
                    ElevatorBody.Location = new System.Drawing.Point(ElevatorBody.Location.X, ElevatorBody.Location.Y - 1);
                    //Using Thread.Sleep to animate the lift and make slow motion 
                    System.Threading.Thread.Sleep(10);

                    //Setting the label text corresponding to the floor on which the lift is...
                    label4.Text = "1";
                    label5.Text = "1";
                    label3.Text = "";
                    label12.Text = "1";

                }
            }
            //If the doors of the lift are open then show a message to close the doors in order move the lift
            else if(left==-76 && y==303)
            {
                label3.Font = new Font("Arial", 10, FontStyle.Bold);
                label3.Font = new Font("Arial", 10, FontStyle.Bold);
                label3.Text = "Please Close Door First";
                label3.Text = "Please Close Door First";
            }
            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ElevatorBody_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
       
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Close_Door_Click(object sender, EventArgs e)
        {
            //Defing the postions of the panels i.e LiftBody and doors on x-axis and y-axis respectively
            int x = left_door.Location.X;
            int y = left_door.Location.Y;
            int a = right_door.Location.X;
            int b = right_door.Location.Y;
            int floor = ElevatorBody.Location.Y;


            //If the doors are open and the lift is on 1st floor only then close the doors
            if (x == -76 && floor==3) {
               
                //Creating a for loop that increments the position of the panels i.e left door and right doors
                for (int s = 0; s < 90; s++)
                {
                    //Moving the left door by 90 to the right
                    left_door.Location = new System.Drawing.Point(left_door.Location.X + 1, left_door.Location.Y);
                    //Using thread.sleep to animate the motion of the doors
                    System.Threading.Thread.Sleep(10);

                    //Moving the right door by 90 to the left 
                    right_door.Location = new System.Drawing.Point(right_door.Location.X - 1, right_door.Location.Y);
                    //Using thread.Sleep to animate the motion of the right door
                    System.Threading.Thread.Sleep(10);
                    label3.Text = "";
                }
            }

           

        }

        private void Open_Door_Click(object sender, EventArgs e)
        {
            //defining the positions  of the doors,lift body on x-axis and y-axis respectively
            int x = left_door.Location.X;
            int y = left_door.Location.Y;
            int a = right_door.Location.X;
            int b = right_door.Location.Y;
            int floor = ElevatorBody.Location.Y;



            //Creating an if statement to only open the doors of the lift if doors are close and lift is on floor 1
            if (x==14 && floor==3) {
                
                //This method inserts the data into the databse according to the status of the lift. Please see the method above for full code
                insertDoorsOpenFloor1();

                //Creating a for loop to increment the position of the panels(leftdoor and right door) by 90 
                for (int s = 0; s < 90; s++)
                {
                    //Moving the left door by 90 on x-axis 
                    left_door.Location = new System.Drawing.Point(left_door.Location.X - 1, left_door.Location.Y);
                    //Using Thread.Sleep to move the door slowly 
                    System.Threading.Thread.Sleep(10);

                    //Moving the right door by 90 on x-axis
                    right_door.Location = new System.Drawing.Point(right_door.Location.X + 1, right_door.Location.Y);
                    //Using sleep to animate the door slowly
                    System.Threading.Thread.Sleep(10);
                }
            }
             
        }

        private void right_door_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Defing the position of (Doors, lift body) on x,y axis respectively
            int x = left_door.Location.X;
            int y = left_door.Location.Y;
            int a = right_door.Location.X;
            int b = right_door.Location.Y;
            int floor = ElevatorBody.Location.Y;


            //Only close the doors if the lift is on floor 0 and doors are open
            if (x == -76 && floor==303)
            {
                //Creating a for loop to increment the position of doors by 90 on x-axis respectively
                for (int s = 0; s < 90; s++)
                {
                    //Moving the left door by 90 on x-axis
                    left_door.Location = new System.Drawing.Point(left_door.Location.X + 1, left_door.Location.Y);
                    System.Threading.Thread.Sleep(10);
                    
                    //Moving the right door by 90 on x-axis
                    right_door.Location = new System.Drawing.Point(right_door.Location.X - 1, right_door.Location.Y);
                    System.Threading.Thread.Sleep(10);
                    label3.Text = "";
                }
            }
        }

        private void doo_Click(object sender, EventArgs e)
        {
            //Defining position of panels(doors,liftbody) on x-axis and y-axis
            int x = left_door.Location.X;
            int y = left_door.Location.Y;
            int a = right_door.Location.X;
            int b = right_door.Location.Y;
            int floor = ElevatorBody.Location.Y;



            //Only Open the doors if the lift is on floor 0 and doors are closed 
            if (x == 14 && floor==303 )
            {
                //This method inserts data into database according to lift status. This also reduces volume of the code
                insertDoorsOpenFloor0();

                //Creating a for loop that increments the position of doors by 90 
                for (int s = 0; s < 90; s++)
                {
                    //Changing the position of the left door 
                    left_door.Location = new System.Drawing.Point(left_door.Location.X - 1, left_door.Location.Y);
                    System.Threading.Thread.Sleep(10);

                    //Moving the right door by 90 on x-axis
                    right_door.Location = new System.Drawing.Point(right_door.Location.X + 1, right_door.Location.Y);
                    System.Threading.Thread.Sleep(10);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void event_label_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shaft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source =LiftData.accdb";
            string dbcommand = "Select LiftFloor, Doors, DateLift,TimeLift from Lift_Data;";
            OleDbConnection conn = new OleDbConnection(dbconnection);
            OleDbCommand comm = new OleDbCommand(dbcommand, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(comm);
            listBox1.Items.Clear();
            try
            {

                conn.Open();

                //while (filled == false)
                adapter.Fill(ds);
                //filled = true;


            }
            catch (Exception ex)
            {
                string message = "Error in connection to datasource" + ex;
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
            finally
            {
                conn.Close();
            }
            foreach (DataRow row in ds.Tables[0].Rows)
            {

                listBox1.Items.Add(row["LiftFloor"] + "\t" + row["Doors"] + "\t" + " (" + row["DateLift"] + ")" + "\t" + " (" + row["TimeLift"] + ")");
            }
            ds.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Clear The data in the listbox 
            listBox1.Items.Clear();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Defining the position of the Elevator Body on x-axis and y-axis respectively
            int x = ElevatorBody.Location.X;
            int y = ElevatorBody.Location.Y;
            int left = left_door.Location.X;

            //Only moving the lift to the first floor if the doors are closed and lift is currently on first floor
            if (y == 303 && left == 14)
            {
                //This method inserts data into database accordingly. Please see the method above
                insertFirstFloor();

                //Creating a for loop that increments the position of the lift by 300. 
                for (int s = 0; s < 300; s++)
                {
                    //Moving the position of the lift by 300 on y-axis
                    ElevatorBody.Location = new System.Drawing.Point(ElevatorBody.Location.X, ElevatorBody.Location.Y - 1);
                    //Using sleep to move the panel slowly
                    System.Threading.Thread.Sleep(10);

                    //Setting the Text of the labels according to the floor the lift is on
                    label4.Text = "1";
                    label5.Text = "1";
                    label3.Text = "";
                    label12.Text = "1";

                }
            }
            //If Doors are open display a message to close the lift doors
            else if (left == -76 && y == 303)
            {
                label3.Font = new Font("Arial", 10, FontStyle.Bold);
                label3.Font = new Font("Arial", 10, FontStyle.Bold);
                label3.Text = "Please Close Door First";
                label3.Text = "Please Close Door First";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Defining the Location of the Panel On x-axis and y-axis respectively 
            int x = ElevatorBody.Location.X;
            int y = ElevatorBody.Location.Y;
            int left = left_door.Location.X;




            //Only moving the elevator downwards when lift if on floor 1 i.e when y-axis=3 and doors must be closed i.e left==14 
            if ((y == 3) && (left == 14))
            {
                insertGroundFloor();
                //A for loop that increments the position of the Panel i.e Lift by 300 
                for (int s = 0; s < 300; s++)
                {
                    ElevatorBody.Location = new System.Drawing.Point(ElevatorBody.Location.X, ElevatorBody.Location.Y + 1);
                    System.Threading.Thread.Sleep(10);

                    //Setting the labels to the position equivalent to the lift 
                    label4.Text = "G";
                    label5.Text = "G";
                    label3.Text = "";
                    label12.Text = "G";

                }


            }
            //If doors are open then display a message to close doors i.e Lift Cant go Down If doors are open
            else if (left == -76 && y == 3)
            {
                label3.Font = new Font("Arial", 10, FontStyle.Bold);
                label3.Font = new Font("Arial", 10, FontStyle.Bold);
                label3.Text = "Please Close Door First";
                label3.Text = "Please Close Door First";
            }

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void left_door_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
    }
    }
