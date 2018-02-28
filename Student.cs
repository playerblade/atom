using System;

namespace Infrastructure
{
  public class Student
  {
    private string name;
    private int age;
    private int cI;

    public Student(string name, int age, int cI){
      this.name=name;
      this.age=age;
      this.cI=cI;
    }

    public string getName(){
      return name;
    }

    public int getAge(){
      return age;
    }

    public int getCI(){
      return cI;
    }
  }

}
