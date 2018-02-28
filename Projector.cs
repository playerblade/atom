using System;

namespace Infrastructure
{
  public class Projector{
    private string brand;
    private string model;

    public Projector(string brand, string model){
      this.brand=brand;
      this.model=model;
    }

    public string getBrand(){
      return brand;
    }

    public string getModel(){
      return model;
    }

  }

}
