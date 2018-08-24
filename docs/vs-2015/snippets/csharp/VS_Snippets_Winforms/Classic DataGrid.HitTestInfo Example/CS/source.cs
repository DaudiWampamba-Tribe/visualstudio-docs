using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

public class Form1: Form
{
 protected DataGrid dataGrid1;
// <Snippet1>
private void dataGrid1_MouseDown
(object sender, System.Windows.Forms.MouseEventArgs e)
{
   Console.WriteLine();
   System.Windows.Forms.DataGrid.HitTestInfo myHitTest;
   // Use the DataGrid control's HitTest method with the x and y properties.
   myHitTest = dataGrid1.HitTest(e.X,e.Y);
   Console.WriteLine(myHitTest);
   Console.WriteLine("Column " + myHitTest.Column);
   Console.WriteLine("Row " + myHitTest.Row);
   Console.WriteLine("Type " + myHitTest.Type);
   Console.WriteLine("ToString " + myHitTest.ToString());
   Console.WriteLine("Hit " + myHitTest.Type.ToString());
}

// </Snippet1>
}
