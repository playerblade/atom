using System;

namespace Infrastructure
{
  public class Computer
  {
    private string brand;
    private string model;
    private string processor;


    public Computer(string brand, string model, string processor){
      this.brand=brand;
      this.model=model;
      this.processor=processor;
    }

    public string getBrand(){
      return brand;
    }

    public string getModel(){
      return model;
    }

    public string getProcessor(){
      return processor;
    }

  }
}
