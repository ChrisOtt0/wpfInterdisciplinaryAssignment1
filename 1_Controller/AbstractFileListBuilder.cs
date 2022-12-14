using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfInterdisciplinaryAssignment1.Domain;

namespace wpfInterdisciplinaryAssignment1.Controller
{
    public abstract class AbstractFileListBuilder
    {
        public abstract void GenerateFileNamesInA();

        public abstract void GenerateFileNamesInB();

        //  get the complete FileLists-object
        public abstract FileLists GetFileLists();
    }
}
