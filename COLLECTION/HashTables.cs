using System.Collections;

namespace COLLECTION;

public class HashTables
{
    //Key - value
    void MainHere()
    {
        Hashtable studentsTable = new Hashtable();
        
        Students stud1 = new Students(1,"John", 98);
        Students stud2 = new Students(2,"Jane", 99);
        Students stud3 = new Students(3,"Mary", 76);
        Students stud4 = new Students(4,"Jack", 56);
        
        studentsTable.Add(stud1.ID, stud1);  // Ключ - это ID студента, а значение это сам студент включая его ID
        studentsTable.Add(stud2.ID, stud2);
        studentsTable.Add(stud3.ID, stud3);
        studentsTable.Add(stud4.ID, stud4);
        studentsTable.Add(stud1, stud4);
        
        
        //
        Students stud1Info = (Students)studentsTable[stud1.ID]; //Можно получить отдельный айтем с известным ID
        
        //Получаем все значения из хэштаблицы
        foreach (DictionaryEntry entry in studentsTable) //DictionaryEntry это ключ значение, где значение это ОБЪЕКТ
        {
            Students studentInfo = (Students)entry.Value; //Key это ID, Value это инфа о студенте
        }

        foreach (Students stud in studentsTable.Values) // в отличие от первого форич тут мы сразу берем не хэш таблицу а ее Value
        {
            
        }
/*--------------------------------------------------------------------*/        
        Students[] students = new Students[5];

        students[0] = new Students(1, "Aston", 67);
        students[1] = new Students(2, "Alex", 61);
        students[2] = new Students(3, "Apex", 98);
        students[3] = new Students(1, "Alyx", 13);
        students[4] = new Students(5, "Alice", 56);

        
        foreach (Students student in students)
        {
            if (!studentsTable.ContainsKey(student.ID))
            {
                studentsTable.Add(student.ID, student);
            }
            else
            {
                Console.WriteLine("Student ID already exists!");
            }
            
        } 
/*--------------------------------------------------------------------*/               
    }
    
    
    
}

class Students
{
    public int ID{get;set;}
    public string name{get;set;}
    public float GPA{get;set;}

    public Students(int id, string name, float gpa)
    {
        ID = id;
        this.name = name;
        GPA = gpa;
    }
}