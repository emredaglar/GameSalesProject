using GameSalesProject.Abstract;
using GameSalesProject.Adapters;
using GameSalesProject.Concrete;
using GameSalesProject.Entities;



Console.WriteLine("---------Player Add----------");
Player player = new Player();
player.FirstName = "Emre";
player.LastName = "Dağlar";
player.PlayerId = 1;
player.NationalityId = 1111111111;
player.Date = new DateTime(1996, 8, 3);

BasePlayerManager manager = new PlayerManager(new PlayerCheckTestManager());

manager.Player_Add(player);
//ServiceReferance tarafından Tc kimlik bilgileri teyit edildi.
//  manager.Update(player);
//  manager.Delete(player);
Console.WriteLine(" ");
Console.WriteLine(" ");

Console.WriteLine("---------Game Add----------");
//Oyun Sistme Ekleme
Product product = new Product();
product.ProductName = "pes 2025";
product.Product_Id = 1;
product.Product_Price = 2500;
product.Product_Description = "Futol oyunu";
product.Product_Category = "Futbol";

GameService gameService = new GameService();
gameService.Game_Add(product);

Console.WriteLine(" ");
Console.WriteLine(" ");
//Campaign(Kampanya Ekleme silme 


Console.WriteLine("---------Campaing Eklendi----------");
Campaign campaign1 = new Campaign();
campaign1.Campaign_id = 1;
campaign1.Campaign_Name = " Discount Mount";
campaign1.Campaign_Discount = -50.0;
campaign1.Campaign_StartDate = new DateTime(2025, 4, 25);
campaign1.Campaign_EndDate = new DateTime(2025, 5, 1);




CampaignManager campaingManager = new CampaignManager();
campaingManager.Campaign_Add(campaign1);

Console.WriteLine("  ");

//Satış Kısmı 
Console.WriteLine("----Satış-----------");
SaleManager saleManager = new SaleManager();
saleManager.Buy(player, product, campaign1);




Console.Read();