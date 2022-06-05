using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
  public partial class frmLinq : Form
  {

    public class Person
    {
      public string Name { get; set; }
      public string City { get; set; }
      public string ZipCode { get; set; }
      public int SomeValue { get; set; }
    }

    List<Person> personData;

    public frmLinq()
    {
      InitializeComponent();
    }

    private void frmLinq_Load(object sender, EventArgs e)
    {
      personData = GetPopulatedData();
      var list = new BindingList<Person>(personData);
      dgPersons.DataSource = list;
    }


    private List<Person> GetPopulatedData()
    {
      List<Person> datos = new List<Person>()
        {
            new Person(){Name="Zdenek", City = "Prague",
                ZipCode = "13000", SomeValue = 10}, // group A

            new Person(){Name="Tomas", City = "Prague",
                ZipCode = "13000", SomeValue = 11}, // group B

            new Person(){Name="Pepa", City = "Brno",
                ZipCode = "50000", SomeValue = 12}, // group B

            new Person(){Name="Jirka", City = "Brno",
                ZipCode = "50010", SomeValue = 13}, // group C

            new Person(){Name="Honza", City = "Brno",
                ZipCode = "50010", SomeValue = 13}, // group C
        };
      return datos;
    }

    private void btnSum_Click(object sender, EventArgs e)
    {
      StringBuilder sb = new StringBuilder();

      var one = personData.AsEnumerable().Sum(i => i.SomeValue);
      var second = personData.Select(c => c.SomeValue).Sum();

      // pseudo pristup do db -- zde krasne pouzijes where
      var itemsInPersons = from o in personData select o.SomeValue;
      var three = Convert.ToDecimal(itemsInPersons.Sum());


      var totalX = personData.AsEnumerable();
      if (txtCity.Text.Length > 0)
        totalX = (IEnumerable<Person>)personData.GroupBy(X => new { X.City }).AsEnumerable();
      else if (txtZipCode.Text.Length > 0)
        totalX = (IEnumerable<Person>)personData.GroupBy(X => new { X.ZipCode }).AsEnumerable();
      var zz = personData.GroupBy(X => new { X.ZipCode }).AsEnumerable().Select(y => y.Sum(i => i.SomeValue));
      var byZipCode = personData.GroupBy(X => new { X.ZipCode }).Select (grp => new { key = grp.Key, count = grp.Count(), sum = grp.Sum (x=>x.SomeValue) });

      sb.AppendLine("ZipCodes: ");
      foreach (var categ in byZipCode)
      {
        // You can refer to one field like this: categ.Key.Ciduad
        sb.AppendLine("Group " + categ.key + ", Count " + categ.count + ", Sum "+categ.sum);
      }
      sb.AppendLine("All Count " + byZipCode.Sum(x => x.count).ToString() + ", Sum " + byZipCode.Sum(x => x.sum).ToString());       
      lblResult.Text = sb.ToString();
    }
  }
}
