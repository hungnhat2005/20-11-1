using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test

{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Class1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {

            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            //ICollection<ElementId> selectedIds = uidoc.Selection.GetElementIds();
            //int totalcount = selectedIds.Count;
            IList<Reference> referenceCollection = uidoc.Selection.PickObjects(Autodesk.Revit.UI.Selection.ObjectType.Edge);
            MessageBox.Show("you have selected " + referenceCollection.Count.ToString() + " edges");
            return Result.Succeeded;
        }
    }
    

    
}
