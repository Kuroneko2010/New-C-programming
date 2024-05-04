using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Xml.Linq;

public class Info
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string Relationship { get; set; }
    public Info(string name, string relationship, string phoneNumber = "0000000000", string address = "Vietnam")
    {
        Name = name;
        PhoneNumber = string.IsNullOrEmpty(phoneNumber) ? "0000000000" : phoneNumber;
        Address = address;
        Relationship = relationship;
    }
}

public class Contact
{

    private List<string> phoneNumbersHistory = new List<string>();

    public List<Info> inputInfo(string filePath, string phoneNumbersFile)
    {
        LoadPhoneNumbersHistory(phoneNumbersFile);
        List<Info> information = new List<Info>();

        Console.WriteLine("Enter person's information (or type 1 when we ask 'done' to finish):");

        Console.Write("Name (max 20 character): ");
        string name = Console.ReadLine();
        while (!IsValidName(name))
        {
            Console.Write("Invalid name, please try again (max 20 character): ");
            name = Console.ReadLine();
        }
        Console.Write("Phone number:  ");
        string? phoneNumber = Console.ReadLine();
        if (string.IsNullOrEmpty(phoneNumber))
        {
            Console.WriteLine("Phone number will be default to 0000000000");

        }
        else
        {
            while (!IsValidPhoneNum(phoneNumber) || IsPhoneNumExisted(phoneNumber, filePath) || IsPhoneNumExistedInHistory(phoneNumber))
            {
                if (!IsValidPhoneNum(phoneNumber))
                {
                    Console.Write("Invalid phone number, please try again : +84 ");
                    phoneNumber = Console.ReadLine();
                }
                if (IsPhoneNumExistedInHistory(phoneNumber))
                {
                    Console.Write("Phone number have already existed : +84 ");
                    phoneNumber = Console.ReadLine();
                }
                if (IsPhoneNumExisted(phoneNumber, filePath))
                {
                    Console.Write("Phone number have already existed : +84 ");
                    phoneNumber = Console.ReadLine();
                }
            }
        }
        Console.Write("Address: ");
        string? address = Console.ReadLine();
        if (string.IsNullOrEmpty(address))
        {
            Console.WriteLine("Address will be default to Vietnam");

        }

        Console.WriteLine("Realtionship : ");
        Console.WriteLine("1 = Family; 2 = Friends; 3 = Classmate; others = Other");
        string choice = Console.ReadLine();
        string relationship;
        if (!string.IsNullOrEmpty(choice))
        {
            switch (choice)
            {
                case "1":
                    relationship = "Family";
                    break;
                case "2":
                    relationship = "Friends";
                    break;
                case "3":
                    relationship = "Classmate";
                    break;
                default:
                    relationship = "Other";
                    break;
            }
        }
        else
        {
            relationship = "";
        }

        if (string.IsNullOrEmpty(address))
        {
            information.Add(new Info(name, relationship, phoneNumber));

        }
        else if (string.IsNullOrEmpty(phoneNumber))
        {

            information.Add(new Info(name, relationship, address));

        }
        else if (string.IsNullOrEmpty(address) && string.IsNullOrEmpty(phoneNumber))
        {
            information.Add(new Info(name, relationship));
        }
        else
        {
            information.Add(new Info(name, relationship, phoneNumber, address));
        }
        phoneNumbersHistory.Add(phoneNumber);
        SavePhoneNumbersHistory(phoneNumbersFile);
        return information;
    }
    private void SavePhoneNumbersHistory(string filePath)
    {
        File.WriteAllLines(filePath, phoneNumbersHistory);
    }
    private void LoadPhoneNumbersHistory(string filePath)
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            phoneNumbersHistory.AddRange(lines);
        }
    }
    private bool IsValidName(string? username)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            return false;
        }
        if (username.Length > 20)
        {
            return false;
        }
        return true;
    }

    private bool IsValidPhoneNum(string phoneNumber)
    {
        Regex regex = new Regex(@"^(0\d{9}|84\d{9})$");
        return regex.IsMatch(phoneNumber);
    }
    private bool IsPhoneNumExisted(string? phoneNumber, string filePath)
    {

        List<Info>? phoneNumbers = new List<Info>();
        if (File.Exists(filePath))
        {
            string jsonContent = File.ReadAllText(filePath);
            phoneNumbers = JsonConvert.DeserializeObject<List<Info>>(jsonContent);
            if (phoneNumbers != null)
            {
                bool isExisted = phoneNumbers.Exists(p => p.PhoneNumber == phoneNumber);

                return isExisted;
            }
            else
            {
                return false;
            }

        }
        else
        {
            return false;
        }

    }
    private bool IsPhoneNumExistedInHistory(string? phoneNumber)
    {
        bool isExisted = phoneNumbersHistory.Contains(phoneNumber);
        return isExisted;
    }
    private bool IsValidAddress(string? address)
    {
        if (string.IsNullOrWhiteSpace(address))
        {
            return false;
        }
        return true;
    }
    public string GetPhoneNumber(string filePath)
    {
        Console.Write("Enter the phone number of the person you want to find : +84 ");
        string? phoneNumber = Console.ReadLine();
        while (!IsValidPhoneNum(phoneNumber))
        {
            Console.Write("Invalid phone number or phone number have already existed, please try again : +84 ");
            phoneNumber = Console.ReadLine();
        }
        return phoneNumber;
    }
    public List<Info> FindAndEditContactInfo(List<Info> information, string phoneNumber, string filePath)
    {

        var contact = information.Find(info => info.PhoneNumber == phoneNumber);
        if (contact != null)
        {
            Console.WriteLine("Contact Information:");
            Console.WriteLine($"Name: {contact.Name}");
            Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
            Console.WriteLine($"Address: {contact.Address}");
            Console.WriteLine("Is this you? (1 = yes, others = no)  : ");
            string? choice = Console.ReadLine();
            if (choice == "1")
            {

                Console.WriteLine("Please enter new information :");
                Console.Write("Name (max 20 character):");
                string? newName = Console.ReadLine();
                while (!IsValidName(newName))
                {
                    Console.Write("Invalid name, please try again (max 20 character): ");
                    newName = Console.ReadLine();
                }
                string? newPhoneNumber;
                Console.WriteLine("Do you want to keep the current phone number? (1 = yes, others = nuh uh) : ");
                string? option = Console.ReadLine();
                if (option == "1")
                {
                    newPhoneNumber = contact.PhoneNumber;
                }
                else
                {
                    Console.Write("Phone number: +84 ");
                    newPhoneNumber = Console.ReadLine();
                    while (!IsValidPhoneNum(newPhoneNumber) || IsPhoneNumExisted(newPhoneNumber, filePath))
                    {
                        Console.Write("Invalid phone number or phone number have already existed, please try again : +84 ");
                        newPhoneNumber = Console.ReadLine();
                    }
                }

                Console.Write("Address: ");
                string? newAddress = Console.ReadLine();
                while (!IsValidAddress(newAddress))
                {
                    Console.WriteLine("Invalid address, please try again : ");
                    newAddress = Console.ReadLine();
                }
                contact.Name = newName;
                contact.PhoneNumber = newPhoneNumber;
                contact.Address = newAddress;
                Console.WriteLine("New information updated successfully");
            }
            else
            {
                Console.WriteLine("No editing information");
            }
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
        return information;

    }
    public List<Info> FindAndDeleteContactInfo(List<Info> information, string filePath, string phoneNumberToDelete)
    {
        Info? contact = information.Find(info => info.PhoneNumber == phoneNumberToDelete);
        if (contact != null)
        {
            Console.WriteLine("Contact Information:");
            Console.WriteLine($"Name: {contact.Name}");
            Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
            Console.WriteLine($"Address: {contact.Address}");
            Console.WriteLine("Dou you want to delete this person's information? (1 = yes, others = no)  : ");
            string? choice = Console.ReadLine();
            if (choice == "1")
            {
                information.Remove(contact);
                using (StreamWriter file = File.CreateText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, information);
                }

                Console.WriteLine("Information deleted successfully");
            }
        }
        else
        {
            Console.WriteLine("Information to delete cannot be found");
        }
        return information;
    }
    public void FindAndDisplayContactInfo(List<Info> information, string filePath, string phoneNumberToDisplay)
    {
        var contact = information.Find(info => info.PhoneNumber == phoneNumberToDisplay);
        if (contact != null)
        {
            Console.WriteLine("This person's information :");
            Console.WriteLine($"Name: {contact.Name}");
            Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
            Console.WriteLine($"Address: {contact.Address}");
        }
        else
        {
            Console.WriteLine("Phone number cannot be found");
        }
    }
    public void DisplayAllContactInfo(List<Info> information, string filePath)
    {
        if (information != null && information.Count > 0)
        {

            foreach (var info in information)
            {
                Console.WriteLine($"Name: {info.Name}");
                Console.WriteLine($"Phone Number: {info.PhoneNumber}");
                Console.WriteLine($"Address: {info.Address}");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Contact list is currently empty.");
        }
    }
}

public class AddressBook
{

    public bool fileExisted(string filePath)
    {
        if (File.Exists(filePath))
        {
            return true;
        }
        return false;
    }
    public List<Info> LoadInfo(string filePath)
    {
        List<Info>? information = new List<Info>();

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                try
                {
                    string jsonContent = reader.ReadToEnd();
                    information = JsonConvert.DeserializeObject<List<Info>>(jsonContent);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        List<Info> sortedInfoList = new List<Info>();
        if (information != null)
        {
            sortedInfoList = information.OrderBy(info => info.Name).ToList();
        }

        return sortedInfoList;
    }

    public void SaveInfo(List<Info> information, string filePath)
    {
        try
        {
            var sortedInfoList = information.OrderBy(info => info.Name).ToList();

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string jsonString = JsonConvert.SerializeObject(sortedInfoList, Formatting.Indented);
                writer.Write(jsonString);
            }

            Console.WriteLine($"Information saved to {filePath} successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string filePath = "info23.json";
        string phoneNumbersFile = "phonenumfile.json";
        Contact contact = new Contact();
        AddressBook addressbook = new AddressBook();
        bool continueDoing = true;
        Console.WriteLine("File link here : ");
        string fullPath = Path.GetFullPath(filePath);
        Console.WriteLine(fullPath);
        while (continueDoing)
        {
            Console.WriteLine("1 : Input information");
            Console.WriteLine("2 : Find and edit information");
            Console.WriteLine("3 : Find and delete information");
            Console.WriteLine("4 : Find and display information");
            Console.WriteLine("5 : Display all information");
            Console.WriteLine("9 : Exit");
            Console.WriteLine("Option : ");

            string? option = Console.ReadLine();
            List<Info>? information = addressbook.LoadInfo(filePath);
            switch (option)
            {
                case "1":

                    while (true)
                    {
                        if (addressbook.fileExisted(filePath))
                        {
                            List<Info>? newInformation = contact.inputInfo(filePath, phoneNumbersFile);
                            if (newInformation != null)
                            {
                                if (information == null)
                                {
                                    information = newInformation;
                                }
                                else
                                {
                                    information.AddRange(newInformation);
                                }

                            }

                            addressbook.SaveInfo(information, filePath);
                            Console.WriteLine("Done?");
                            Console.WriteLine("1 = yes, others = no");
                            string? choice = Console.ReadLine();
                            if (choice == "1")
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Contact list is currently empty, a new json file will be created when you enter information");
                            List<Info> newInformation = contact.inputInfo(filePath, phoneNumbersFile);
                            information.AddRange(information);

                            addressbook.SaveInfo(information, filePath);
                            Console.WriteLine("1 = yes, others = no");
                            string? choice = Console.ReadLine();
                            if (choice == "1")
                            {
                                break;
                            }
                        }
                    }
                    break;
                case "2":

                    string phoneNumberToEdit = contact.GetPhoneNumber(filePath);
                    information = contact.FindAndEditContactInfo(information, phoneNumberToEdit, filePath);

                    addressbook.SaveInfo(information, filePath);
                    break;
                case "3":
                    string phoneNumberToDelete = contact.GetPhoneNumber(filePath);
                    information = contact.FindAndDeleteContactInfo(information, filePath, phoneNumberToDelete);
                    addressbook.SaveInfo(information, filePath);
                    break;
                case "4":
                    string phoneNumberToDisplay = contact.GetPhoneNumber(filePath);
                    contact.FindAndDisplayContactInfo(information, filePath, phoneNumberToDisplay);
                    break;
                case "5":
                    information = addressbook.LoadInfo(filePath);

                    contact.DisplayAllContactInfo(information, filePath);
                    break;
                case "9":
                    continueDoing = false;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }


    }
}