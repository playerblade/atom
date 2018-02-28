using System;

namespace Infrastructure
{

  public class Laboratory
  {
    private int index,index2,index3; //Indexadores
    private string name;
    private Student []students = new Student[2];
    private Computer []computers = new Computer[3];
    private Projector []projectors = new Projector[3];

    public Laboratory(string name){
      this.name=name;
      index = index2 = index3 = 0;

    }

    public void addStudent(Student newStudent){
      if(index >= students.Length){
        Console.WriteLine("Almacenamiento Lleno!!! Estudiantes");
      }else{
        this.students[index]= newStudent;
        index++;
      }
    }

    public void addComputer(Computer newComputer){
      if(index2 >= computers.Length){
        Console.WriteLine("Almacenamiento Lleno!!! Computadoras");
      }else{
        this.computers[index2]= newComputer;
        index2++;
      }
    }

    public void addProjector(Projector newProjector){
      if(index3 >= projectors.Length){
        Console.WriteLine("Almacenamiento Lleno!!! Proyectores");
      }else{
        this.projectors[index3]= newProjector;
        index3++;
      }
    }

    public void showStudent(){
      int i;
      for( i = 0; i < index; i++ ){
        Console.WriteLine("Nombre: " + students[i].getName());
        Console.WriteLine("Edad: " + students[i].getAge());
        Console.WriteLine("CI: " + students[i].getCI());
        Console.WriteLine("");
      }
    }

    public int showQuantityProcessorComputers(string setProcessor){
      int i,aux=0;
      for( i = 0; i < computers.Length; i++ ){
        if( setProcessor.Equals(computers[i].getProcessor()) ){
          aux++;
        }
      }
      return aux;
    }

    public string getName(){
      return name;
    }

    static void Main(string[]agrs){
      Laboratory laboratory = new Laboratory("Laboratorio de Quimica");
      //Añadiendo Estudiantes
      Student stu1 = new Student("Genaro", 18, 23456654);
      Student stu2 = new Student("Cenir", 19, 98384);
      laboratory.addStudent(stu1);
      laboratory.addStudent(stu2);
      //Añadiendo Computadoras
      Computer compu1 = new Computer("Dell", "NP2L3", "core i3");
      Computer compu2 = new Computer("HP", "OPND67", "core i3");
      Computer compu3 = new Computer("Samsung", "TEGN4", "core i7");
      laboratory.addComputer(compu1);
      laboratory.addComputer(compu2);
      laboratory.addComputer(compu3);
      //A
      Projector pro1 = new Projector("HP", "UID980");
      Projector pro2 = new Projector("Akita", "OBD7W9M");
      laboratory.addProjector(pro1);
      laboratory.addProjector(pro2);

      Console.WriteLine("Mostrando Estudiantes...");
      laboratory.showStudent();

      Console.WriteLine("Cuantos Computadoras tienen Procesadores core i3   ?");
      Console.WriteLine("Cantidad es: " + laboratory.showQuantityProcessorComputers("core i3"));

    }

  }
}
