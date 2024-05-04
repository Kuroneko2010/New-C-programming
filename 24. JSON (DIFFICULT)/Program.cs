using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
class Info
{
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }    
    public string? Address { get; set; }
    public string? Relationship { get; set; }   
}
class AddressBook
{
    public void SaveInfo(List<Info> information, string filePath)
    {
        try
        {      
            string jsonString = JsonConvert.SerializeObject(information, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine($"Thông tin đã được lưu vào {filePath}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    } 
    public List<Info> LoadInfo(string filePath)
    {
        List<Info> ?information = new List<Info>();
        if (File.Exists(filePath))
        {
            string? jsonContent = File.ReadAllText(filePath);   
            information = JsonConvert.DeserializeObject<List<Info>>(jsonContent);
        }
        return information;
    }
    public bool FileExisted(string filePath)
    {
        if(File.Exists(filePath))
        {
            return true;
        }
        return false;
    }
    public List<Info> SortingContact(List<Info> information)
    {
        var sortedInfoList = information.OrderBy(info => info.Name).ToList();
        return sortedInfoList;
    }
    public void BackupAddressBook(List<Info> information, string backUpFilePath)
    {
        try
        {
            string jsonString = JsonConvert.SerializeObject(information, Formatting.Indented);
            File.WriteAllText(backUpFilePath, jsonString);
            Console.WriteLine($"Danh bạ đã được sao lưu vào {backUpFilePath}");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Lỗi khi sao lưu danh bạ {ex.Message}");
        }
    }
    public List<Info> RestoreAddressBook(string backUpFilePath)
    {
        List<Info>restoredInformation = new List<Info>();
        try
        {
            if(File.Exists(backUpFilePath))
            {
                string jsonContent = File.ReadAllText(backUpFilePath);
                restoredInformation = JsonConvert.DeserializeObject<List<Info>>(jsonContent);
                Console.WriteLine("Danh bạ đã được phục hồi từ file sao lưu");
            }
            else
            {
                Console.WriteLine("Không tìm thấy file sao lưu");
            }
        }
        catch(Exception ex) 
        {
            Console.WriteLine($"Lỗi khi phục hồi danh bạ {ex.Message}");
        }
        return restoredInformation;
    }
}

class Contact
{
    private static List<string> phoneNumbersHistory = new List<string>();
    public List<Info> GetContact (List<Info> newInform, string filePath)
    {
        string? name;
        string? phoneNumber;
        string? address;
        Console.WriteLine("Hãy nhập vào họ tên: ");
        name = Console.ReadLine();
        while (!IsValidName(name))
        {
            Console.WriteLine("Nhập tên đã bị lỗi, vui lòng nhập lại: ");
            name = Console.ReadLine ();
        }   

        Console.WriteLine("Hãy nhập vào số điện thoại: ");
        phoneNumber = Console.ReadLine ();
        while (!IsValidPhoneNumber(phoneNumber) || IsPhoneNumberDuplicate(phoneNumber) || IsPhoneNumberExisted(filePath, phoneNumber))
        {
            if (!IsValidPhoneNumber(phoneNumber))
            {
                Console.WriteLine("Số điện thoại nhập vào đã bị lỗi, vui lòng nhập lại: ");
                phoneNumber = Console.ReadLine();
                

            }
            else
            {
                Console.WriteLine("Số điện thoại nhập vào đã bị trùng lặp, vui lòng nhặp lại: ");
                phoneNumber = Console.ReadLine();
                

            }

        }
        phoneNumbersHistory.Add(phoneNumber);
    
        Console.WriteLine("Hãy nhập vào địa chỉ liên lạc: ");
        address = Console.ReadLine();
        while (!IsValidAddress (address))
        {
            Console.WriteLine("Địa chỉ liên lạc không thể nào là khoảng trắng, vui lòng nhặp lại: ");
            address = Console.ReadLine ();
        }
        newInform.Add(new Info { Name = name, PhoneNumber = phoneNumber, Address = address });

        return newInform;
    }
    
    //ISVALIDPHONENUMBER == GIGACHAD VERYCHAD SUPERCHAD!
    public bool IsValidPhoneNumber(string? phoneNumber)
    {
        
        char[] phoneDigit = phoneNumber.ToCharArray();
        if (string.IsNullOrEmpty(phoneNumber))
        {
            return false;
        }
        if (phoneDigit.Length == 11 && phoneNumber.StartsWith("84"))
        {
            return true;
        }
        if (phoneDigit.Length != 10)
        {
            return false;
        }
        else if (phoneDigit.Length == 10 && !(phoneNumber.StartsWith("0")))
        {
            return false;
        }
        
        int intPhoneDigit;
        foreach (char digit in phoneDigit) 
        { 
            if (!int.TryParse(digit.ToString(), out intPhoneDigit))
            {
                return false;
            }
        }
        return true;
    }
    public bool IsValidName (string? name)
    {
        char[] nameCharacter = name.ToCharArray();
        if (string.IsNullOrEmpty(name)) 
        { 
            return false;
        }
        for (int i= 0; i<nameCharacter.Length; i++) 
        {
            if (char.IsDigit(nameCharacter[i]))
            {
                return false;
            }
        }
        return true;
    }
    private bool IsPhoneNumberDuplicate(string? phoneNumber)
    {
        return phoneNumbersHistory.Contains(phoneNumber);
    }
    private bool IsPhoneNumberExisted(string? filePath, string? phoneNumber)
    {
        List<Info>?information = new List<Info>();
        if (File.Exists(filePath))
        {
            string jsonContent = File.ReadAllText(filePath);
            information = JsonConvert.DeserializeObject<List<Info>>(jsonContent);
        }
        if (information != null)
        {
            bool isExisted = information.Exists(p => p.PhoneNumber == phoneNumber);
            return isExisted;
        }
        return false;
    }
    private bool IsValidAddress(string? address)
    {
        if (string.IsNullOrEmpty(address))
        {
            return false;
        }
        return true;
    }
   
    //Hàm chức năng JSON cringe cringe cringe cringe cringe cringe cringe cringe cringe
    public string GetPhoneNumber(string filePath)
    {
        Console.Write("Hãy nhập vào số điện thoại: ");
        string? phoneNumber = Console.ReadLine();
        while (!IsValidPhoneNumber(phoneNumber))
        {
            Console.Write("Số điện thoại đã bị nhập sai hoặc bị trùng lặp, vui lòng nhập lại : ");
            phoneNumber = Console.ReadLine();
        }
        
        return phoneNumber;
    }
    public List<Info> CheckAndUpdateInfo(List<Info> information, string phoneNumber, string filePath )
    {
        var contact = information.Find(info => info.PhoneNumber == phoneNumber);
        if (contact != null)
        {
            Console.WriteLine("Thông tin liên hệ: ");
            Console.WriteLine($"Name: {contact.Name}");
            Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
            Console.WriteLine($"Address: {contact.Address}");
            Console.WriteLine("Đây có phải là bạn không? (Bấm 1 = Có, bấm phím bất kỳ = Không)");
            string? choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Vui lòng nhập vào thông tin mới: ");
                Console.WriteLine("Nhập vào tên mới: ");
                string? newName = Console.ReadLine();   
                while (!IsValidName(newName))
                {
                    Console.WriteLine("Nhập tên đã bị lỗi, vui lòng nhập lại: ");
                    newName = Console.ReadLine();
                }
                string? newPhoneNumber;
                Console.WriteLine("Bạn có muốn giữ số điện thoại này không? (Bấm 1 = Có, bấm phím bất kỳ = Không)");
                string? option = Console.ReadLine();
                if (option == "1")
                {
                    newPhoneNumber = contact.PhoneNumber;
                }
                else
                {
                    Console.WriteLine("Hãy nhập vào số điện thoại mới: ");
                    newPhoneNumber = Console.ReadLine();
                    

                    while (!IsValidPhoneNumber(newPhoneNumber) || IsPhoneNumberDuplicate(newPhoneNumber) || IsPhoneNumberExisted(filePath, newPhoneNumber))
                    {
                        if (!IsValidPhoneNumber(phoneNumber))
                        {
                            Console.WriteLine("Số điện thoại nhập vào đã bị lỗi, vui lòng nhập lại: ");
                            newPhoneNumber = Console.ReadLine();
                            
                        }
                        else
                        {
                            Console.WriteLine("Số điện thoại nhập vào đã bị trùng lặp, vui lòng nhặp lại: ");
                            newPhoneNumber = Console.ReadLine();
                            
                        }
                    }
                }
                Console.WriteLine("Nhập vào địa chỉ liên lạc: ");
                string? newAddress = Console.ReadLine();
                while (!IsValidAddress(newAddress)) 
                {
                    Console.WriteLine("Địa chỉ nhập vào không thể nào là khoảng trắng, vui lòng nhập lại");
                    newAddress = Console.ReadLine();
                }
                contact.Name = newName;
                contact.PhoneNumber = newPhoneNumber;
                contact.Address = newAddress;
                Console.WriteLine("Thông tin đã được chỉnh sửa thành công");                
            }       
        }
        else
        {
            Console.WriteLine("Không thể tìm thấy thông tin, ERROR 404");
        }
        return information;
    }
    public List<Info> CheckAndDeleteInfo(List<Info> information, string phoneNumber, string filePath )
    {
        //check
        var contact = information.Find(info => info.PhoneNumber == phoneNumber);
        if (contact != null)
        {
            Console.WriteLine("Thông tin liên hệ: ");
            Console.WriteLine($"Name: {contact.Name}");
            Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
            Console.WriteLine($"Address: {contact.Address}");
            Console.WriteLine("Đây có phải là bạn không? (Bấm 1 = Có, bấm phím bất kỳ = Không)");
            string? choice = Console.ReadLine();
            if (choice == "1")
            {
                information.Remove(contact);
                Console.WriteLine("Thông tin đã được xóa");
            }
            
        }
        else
        {
            Console.WriteLine("Thông tin cần xóa không thể tìm thấy, ERROR 405");
        }
        return information;
    }
    public void FindAndDisplayInfo(List<Info> information, string phoneNumber, string filePath)
    {
        var contact = information.Find(info => info.PhoneNumber == phoneNumber);
        if (contact != null)
        {
            Console.WriteLine("Thông tin liên hệ: ");
            Console.WriteLine($"Name: {contact.Name}");
            Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
            Console.WriteLine($"Address: {contact.Address}");
            Console.WriteLine("");
            Console.WriteLine("Đây có phải là bạn không? (Bấm 1 = Có, bấm phím bất kỳ = Không)");
            string? choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Cảm ơn bạn vì đã sử dụng chương trình");
            }
            else
            {
                Console.WriteLine("Lỗi không rõ, ERROR 383");
            }
        }
        else
        {
            Console.WriteLine("Thông tin cần trình bày không thể được tìm thấy, ERROR 406");
        }
    }
    public void FindAndDisplaySortedInfo(List<Info> information, string filePath)
    {
        if (information != null && information.Count > 0)
        {
            foreach (var info in information)
            {
                Console.WriteLine($"Name: {info.Name}");
                Console.WriteLine($"PhoneNumber: {info.PhoneNumber}");
                Console.WriteLine($"Address: {info.Address}");
                Console.WriteLine("");
            }
        }
        else { Console.WriteLine("Danh bạ hiện tại đang trống, hãy chọn 1 để nhập thông tin vào"); }
    }


}
internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = "Addressbook.json";
        string backUpFilePath = "Backupfile.json";
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        List<Info> newInform = new List<Info>();
        Contact contact = new Contact();
        AddressBook addressBook = new AddressBook();
        List<Info> existingInformation = addressBook.LoadInfo(filePath);
        Console.WriteLine("CHÀO MỪNG BẠN ĐÃ ĐẾN VỚI GIAO DIỆN CỦA CHƯƠNG TRÌNH, HÃY THAO TÁC Ở PHẦN MENU ĐỂ TIẾP TỤC");
        Console.WriteLine("Xin cảm ơn!");
        while (true)
        {
            string stringChoice;
            int choice;
            Console.WriteLine("");
            Console.WriteLine("***MENU***");
            Console.WriteLine("Hãy vui lòng chọn 1 trong những lựa chọn sau để tiếp tục: ");
            Console.WriteLine("(0). Thoát chương trình");
            Console.WriteLine("(1). Thêm hoặc cập nhật liên lạc: ");
            Console.WriteLine("(2). Tìm và sửa thông tin liên lạc dựa trên số điện thoại");
            Console.WriteLine("(3). Tìm và xóa thông tin liên lạc dựa trên số điện thoại");
            Console.WriteLine("(4). Tìm thông tin người dùng dựa trên số điện thoại");
            Console.WriteLine("(5). Hiển thị toàn bộ danh bạ theo bảng chữ cái");
            Console.WriteLine("(6). Sao lưu danh bạ vào một file mới");
            Console.WriteLine("(7). Phục hồi danh bạ từ file đã sao lưu (phải thực hiện option 6 trước)");
            Console.WriteLine("");
            stringChoice = Console.ReadLine();
            while (!int.TryParse(stringChoice, out choice) || choice > 7 || choice < 0)
            {
                Console.WriteLine("Lựa chọn của bạn không hợp lệ, vui lòng nhập lại");
                stringChoice = Console.ReadLine();
            }
            switch (choice)
            {
                case 0:
                    Console.WriteLine("CẢM ƠN BẠN VÌ ĐÃ SỬ DỤNG CHƯƠNG TRÌNH, HẸN GẶP LẠI!");
                    return;
                case 1:
                    while (true)
                    {

                        List<Info> newInformation = contact.GetContact(newInform, filePath);

                        existingInformation.AddRange(newInformation);
                        addressBook.SaveInfo(existingInformation, filePath);

                        Console.WriteLine("Nhập 0 để tiếp tục nhập số thông tin, hoặc nhấn phím bất kỳ để kết thúc.");
                        string input = Console.ReadLine();
                        if (input != "0")
                        {
                            break;
                        }
                    }
                    break;
                case 2:
                    string phoneNumberToEdit = contact.GetPhoneNumber(filePath);
                    existingInformation = contact.CheckAndUpdateInfo(existingInformation, phoneNumberToEdit, filePath);
                    addressBook.SortingContact(existingInformation);
                    addressBook.SaveInfo(existingInformation, filePath);
                    break;
                case 3:
                    string phoneNumberToCheck = contact.GetPhoneNumber(filePath);
                    existingInformation = contact.CheckAndDeleteInfo(existingInformation, phoneNumberToCheck, filePath);
                    addressBook.SortingContact(existingInformation);
                    addressBook.SaveInfo(existingInformation, filePath);
                    break;
                case 4:
                    string phoneNumberToFind = contact.GetPhoneNumber(filePath);
                    contact.FindAndDisplayInfo(existingInformation, phoneNumberToFind, filePath);
                    break;
                case 5:
                    Console.WriteLine("***Danh bạ của bạn theo thứ tự bảng chữ cái***");
                    existingInformation = addressBook.LoadInfo(filePath);
                    List<Info> sortedList = addressBook.SortingContact(existingInformation);
                    contact.FindAndDisplaySortedInfo(sortedList, filePath);
                    string jsonFileLink = Path.Combine(Directory.GetCurrentDirectory(), filePath);
                    if (!File.Exists(filePath))
                    {
                        Console.WriteLine($"Tệp JSON không tồn tại. Sẽ tạo tệp mới khi bạn nhập vào thông tin. (Bấm phím 1 tại phần menu)");
                    }
                    else
                    {
                        Console.WriteLine($"Tệp JSON đã tồn tại. Bạn có thể tìm nó ở đây: ");
                        Console.WriteLine(jsonFileLink);
                    }
                    break;
                case 6:
                    string backUpFileLink = Path.Combine(Directory.GetCurrentDirectory(), backUpFilePath);
                    addressBook.BackupAddressBook(existingInformation, backUpFilePath);
                    Console.WriteLine("File sao lưu năm ở đây: ");
                    Console.WriteLine(backUpFileLink);
                    break;
                case 7:
                    existingInformation = addressBook.RestoreAddressBook(backUpFilePath);
                    addressBook.SaveInfo(existingInformation, filePath);
                    break;
            }
        }
    }
}
