namespace Aula23
{
    public class Person
    {
        public string Name;
        public int Age;

        public bool IfLegalPerson(int age)
        {
            if (Age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public string IfLegalPersonRefactor(int age)
        {
            string result = string.Empty;
            if (Age >= 18)
            {
                result = "A pessoa é maior de Idade!";
                return result;
            }
            else
            {
                result = "A pessoa é menor de Idade!";
                return result;
            }


        }

        public string IfLegalPersonRefactorName(int age, string name)
        {
            string result = string.Empty;
            if (Age >= 18)
            {
                result = "O" + name + "é maior de Idade!";
                return result;
            }
            else
            {
                result = "O" +name + "pessoa é menor de Idade!";
                return result;
            }
        }
    }
}