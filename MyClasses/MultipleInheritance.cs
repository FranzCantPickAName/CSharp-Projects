
namespace MyClasses
{
    //Possible by using interface
    interface Teacher4
    {
    }
    interface Physician4 { }

    interface MedicalTeacher : Teacher4, Physician4 { }

}
