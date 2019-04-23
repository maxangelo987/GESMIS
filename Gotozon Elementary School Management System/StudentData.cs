using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace School_Management_System
{
    [Serializable]
    class StudentData
    {
        /// <summary>
        /// Personal Information
        /// </summary>
        public string id { set; get; }
        public string grade { set; get; }
        public string name { set; get; }
        public string address { set; get; }
        public string placeofbirth { set; get; }
        public string dateofbirth { set; get; }
        public string gender { set; get; }
        public string citizenship { set; get; }
        public string father { set; get; }
        public string mother { set; get; }
        public string contact { set; get; }




        /// <summary>
        /// Grade III Subjects
        /// </summary>
        public string MotherTongueIIIQ1 { set; get; }
        public string MotherTongueIIIQ2 { set; get; }
        public string MotherTongueIIIQ3 { set; get; }
        public string MotherTongueIIIQ4 { set; get; }
        public string MotherTongueIIIFG { set; get; }

        public string FilipinoIIIQ1 { set; get; }
        public string FilipinoIIIQ2 { set; get; }
        public string FilipinoIIIQ3 { set; get; }
        public string FilipinoIIIQ4 { set; get; }
        public string FilipinoIIIFG { set; get; }

        public string EnglishIIIQ1 { set; get; }
        public string EnglishIIIQ2 { set; get; }
        public string EnglishIIIQ3 { set; get; }
        public string EnglishIIIQ4 { set; get; }
        public string EnglishIIIFG { set; get; }

        public string MathematicsIIIQ1 { set; get; }
        public string MathematicsIIIQ2 { set; get; }
        public string MathematicsIIIQ3 { set; get; }
        public string MathematicsIIIQ4 { set; get; }
        public string MathematicsIIIFG { set; get; }

        public string ScienceIIIQ1 { set; get; }
        public string ScienceIIIQ2 { set; get; }
        public string ScienceIIIQ3 { set; get; }
        public string ScienceIIIQ4 { set; get; }
        public string ScienceIIIFG { set; get; }

        public string APIIIQ1 { set; get; }
        public string APIIIQ2 { set; get; }
        public string APIIIQ3 { set; get; }
        public string APIIIQ4 { set; get; }
        public string APIIIFG { set; get; }

        public string EPPTLEIIIQ1 { set; get; }
        public string EPPTLEIIIQ2 { set; get; }
        public string EPPTLEIIIQ3 { set; get; }
        public string EPPTLEIIIQ4 { set; get; }
        public string EPPTLEIIIFG { set; get; }

        public string MAPEHIIIQ1 { set; get; }
        public string MAPEHIIIQ2 { set; get; }
        public string MAPEHIIIQ3 { set; get; }
        public string MAPEHIIIQ4 { set; get; }
        public string MAPEHIIIFG { set; get; }

        public string EsPIIIQ1 { set; get; }
        public string EsPIIIQ2 { set; get; }
        public string EsPIIIQ3 { set; get; }
        public string EsPIIIQ4 { set; get; }
        public string EsPIIIFG { set; get; }
        
        /// <summary>
        ///  Grade IV Subjects
        /// </summary>
        
        public string MotherTongueIVQ1 { set; get; }
        public string MotherTongueIVQ2 { set; get; }
        public string MotherTongueIVQ3 { set; get; }
        public string MotherTongueIVQ4 { set; get; }
        public string MotherTongueIVFG { set; get; }
       
        public string FilipinoIVQ1 { set; get; }
        public string FilipinoIVQ2 { set; get; }
        public string FilipinoIVQ3 { set; get; }
        public string FilipinoIVQ4 { set; get; }
        public string FilipinoIVFG { set; get; }

        public string EnglishIVQ1 { set; get; }
        public string EnglishIVQ2 { set; get; }
        public string EnglishIVQ3 { set; get; }
        public string EnglishIVQ4 { set; get; }
        public string EnglishIVFG { set; get; }

        public string MathematicsIVQ1 { set; get; }
        public string MathematicsIVQ2 { set; get; }
        public string MathematicsIVQ3 { set; get; }
        public string MathematicsIVQ4 { set; get; }
        public string MathematicsIVFG { set; get; }

        public string ScienceIVQ1 { set; get; }
        public string ScienceIVQ2 { set; get; }
        public string ScienceIVQ3 { set; get; }
        public string ScienceIVQ4 { set; get; }
        public string ScienceIVFG { set; get; }

        public string APIVQ1 { set; get; }
        public string APIVQ2 { set; get; }
        public string APIVQ3 { set; get; }
        public string APIVQ4 { set; get; }
        public string APIVFG { set; get; }

        public string EPPTLEIVQ1 { set; get; }
        public string EPPTLEIVQ2 { set; get; }
        public string EPPTLEIVQ3 { set; get; }
        public string EPPTLEIVQ4 { set; get; }
        public string EPPTLEIVFG { set; get; }

        public string MAPEHIVQ1 { set; get; }
        public string MAPEHIVQ2 { set; get; }
        public string MAPEHIVQ3 { set; get; }
        public string MAPEHIVQ4 { set; get; }
        public string MAPEHIVFG { set; get; }

        public string EsPIVQ1 { set; get; }
        public string EsPIVQ2 { set; get; }
        public string EsPIVQ3 { set; get; }
        public string EsPIVQ4 { set; get; }
        public string EsPIVFG { set; get; }

        /// <summary>
        /// Grade V Subjects
        /// </summary>
        
        public string FilipinoVQ1 { set; get; }
        public string FilipinoVQ2 { set; get; }
        public string FilipinoVQ3 { set; get; }
        public string FilipinoVQ4 { set; get; }
        public string FilipinoVFG { set; get; }

        public string EnglishVQ1 { set; get; }
        public string EnglishVQ2 { set; get; }
        public string EnglishVQ3 { set; get; }
        public string EnglishVQ4 { set; get; }
        public string EnglishVFG { set; get; }

        public string MathematicsVQ1 { set; get; }
        public string MathematicsVQ2 { set; get; }
        public string MathematicsVQ3 { set; get; }
        public string MathematicsVQ4 { set; get; }
        public string MathematicsVQ5 { set; get; }

        public string ScienceVQ1 { set; get; }
        public string ScienceVQ2 { set; get; }
        public string ScienceVQ3 { set; get; }
        public string ScienceVQ4 { set; get; }
        public string ScienceVFG { set; get; }

        public string APVQ1 { set; get; }
        public string APVQ2 { set; get; }
        public string APVQ3 { set; get; }
        public string APVQ4 { set; get; }
        public string APVFG { set; get; }

        public string EPPTLEVQ1 { set; get; }
        public string EPPTLEVQ2 { set; get; }
        public string EPPTLEVQ3 { set; get; }
        public string EPPTLEVQ4 { set; get; }
        public string EPPTLEVFG { set; get; }

        public string MAPEHVQ1 { set; get; }
        public string MAPEHVQ2 { set; get; }
        public string MAPEHVQ3 { set; get; }
        public string MAPEHVQ4 { set; get; }
        public string MAPEHVFG { set; get; }

        public string EsPVQ1 { set; get; }
        public string EsPVQ2 { set; get; }
        public string EsPVQ3 { set; get; }
        public string EsPVQ4 { set; get; }
        public string EsPVFG { set; get; }


        /// <summary>
        /// Grade VI Subjects
        /// </summary>

        public string FilipinoVIQ1 { set; get; }
        public string EnglishVIQ1 { set; get; }
        public string MathematicsVIQ1 { set; get; }
        public string ScienceVIQ1 { set; get; }
        public string APVIQ1 { set; get; }
        public string EPPTLEVIQ1 { set; get; }
        public string MAPEHVIQ1 { set; get; }
        public string EsPVIQ1 { set; get; }


        public Image pic { set; get; }

        
    }
}
