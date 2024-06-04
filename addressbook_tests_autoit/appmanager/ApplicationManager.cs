using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace addressbook_tests_autoit
{
    public class ApplicationManager
    {
        public static string WINTITLE = "Free Address Book";
        private AutoItX3 aux;
        private GroupHelper groupHelper;


        public ApplicationManager()
        {
            aux = new AutoItX3();
            aux.Run(@"C:\Users\freya\source\repos\FreeAddressBookPortable\AddressBook.exe", "", aux.SW_SHOW);
            aux.WinActivate(WINTITLE);
            aux.WinWait(WINTITLE);
            aux.WinWaitActive(WINTITLE);

            groupHelper = new GroupHelper(this);
        }

        public void Stop()
        {
            aux.ControlClick(WINTITLE, "$Exit", "WindowsForms10.BUTTON.app.0.1114f81");
            aux.WinClose(WINTITLE);
        }

        public AutoItX3 Aux
        {
            get 
            {
                return aux;
            }
        }


        public GroupHelper Groups {
            get { return groupHelper; }
        }
    }

}
