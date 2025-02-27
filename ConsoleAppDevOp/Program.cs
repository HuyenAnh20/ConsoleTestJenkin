﻿using System;
using System.Collections.Generic;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }

    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Position: {Position}");
    }
}

class Program
{
    static List<Employee> employees = new List<Employee>();
    static int nextId = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- QUẢN LÝ NHÂN VIÊN ---");
            Console.WriteLine("1. Thêm nhân viên");
            Console.WriteLine("2. Hiển thị danh sách nhân viên");
            Console.WriteLine("3. Sửa thông tin nhân viên");
            Console.WriteLine("4. Xóa nhân viên");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng: ");

            switch (Console.ReadLine())
            {
                case "1": AddEmployee(); break;
                case "2": DisplayEmployees(); break;
                case "3": EditEmployee(); break;
                case "4": DeleteEmployee(); break;
                case "5": return;
                default: Console.WriteLine("Chọn sai, vui lòng thử lại!"); break;
            }
        }
    }

    static void AddEmployee()
    {
        Console.Write("Nhập tên nhân viên: ");
        string name = Console.ReadLine();

        Console.Write("Nhập vị trí: ");
        string position = Console.ReadLine();

        employees.Add(new Employee { Id = nextId++, Name = name, Position = position });
        Console.WriteLine("✔️ Đã thêm nhân viên thành công!");
    }

    static void DisplayEmployees()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("❌ Không có nhân viên nào!");
            return;
        }

        foreach (var emp in employees)
        {
            emp.Display();
        }
    }

    static void EditEmployee()
    {
        Console.Write("Nhập ID nhân viên cần sửa: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var emp = employees.Find(e => e.Id == id);

            if (emp == null)
            {
                Console.WriteLine("❌ Không tìm thấy nhân viên!");
                return;
            }

            Console.Write("Nhập tên mới: ");
            emp.Name = Console.ReadLine();

            Console.Write("Nhập vị trí mới: ");
            emp.Position = Console.ReadLine();

            Console.WriteLine("✔️ Đã cập nhật thông tin nhân viên!");
        }
        else
        {
            Console.WriteLine("❌ ID không hợp lệ!");
        }
    }

    static void DeleteEmployee()
    {
        Console.Write("Nhập ID nhân viên cần xóa: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var emp = employees.Find(e => e.Id == id);

            if (emp == null)
            {
                Console.WriteLine("❌ Không tìm thấy nhân viên!");
                return;
            }

            employees.Remove(emp);
            Console.WriteLine("✔️ Đã xóa nhân viên thành công!");
        }
        else
        {
            Console.WriteLine("❌ ID không hợp lệ!");
        }
    }
}