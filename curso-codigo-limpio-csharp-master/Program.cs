﻿
//https://www.c-sharpcorner.com/UploadFile/3ab935/how-does-your-code-smell/
//namespace ToDo;


///Inicializamos la lista
List<string> TaskList = new List<string>();

int menuSelected = 0;
do
{
    menuSelected = ShowMainMenu();
    if ((Menu)menuSelected == Menu.Add)
    {
        ShowMenuAdd();
    }
    else if ((Menu)menuSelected == Menu.Remove)
    {
        ShowMenuRemove();
    }
    else if ((Menu)menuSelected == Menu.List)
    {
        ShowMenuTaskList();
    }
} while ((Menu)menuSelected != Menu.Exit);

/// <summary>
/// Show the option for task 
/// </summary>
/// <returns>Returns option selected by user</returns>
int ShowMainMenu()
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Ingrese la opción a realizar: ");
    Console.WriteLine("1. Nueva tarea");
    Console.WriteLine("2. Remover tarea");
    Console.WriteLine("3. Tareas pendientes");
    Console.WriteLine("4. Salir");

    string option = Console.ReadLine();
    return Convert.ToInt32(option);
}

void ShowMenuRemove()
{
    try
    {
        Console.WriteLine("Ingrese el número de la tarea a remover: ");
        ShowMenuTaskList();

        string option = Console.ReadLine();
        
        // Remove one position because the array starts in 0
        int indexToRemove = Convert.ToInt32(option) - 1;

        if (indexToRemove > (TaskList.Count - 1) || indexToRemove < 0)
        {
            Console.WriteLine("Numero no valido");
        }
        else
        {
            if (indexToRemove > -1 && TaskList.Count > 0)
            {
                string task = TaskList[indexToRemove];
                TaskList.RemoveAt(indexToRemove);
                Console.WriteLine($"Tarea {task} eliminada");
            }
        }

    }
    catch (Exception ex)
    {
        //throw ex;
        Console.WriteLine("Error inesperado");
    }
}

void ShowMenuAdd()
{
    try
    {
        Console.WriteLine("Ingrese el nombre de la tarea: ");
        string task = Console.ReadLine();
        TaskList.Add(task);
        Console.WriteLine("Tarea registrada");
    }
    catch (Exception ex)
    {
        //throw ex;
        Console.WriteLine("Error inesperado");
    }
}

void ShowMenuTaskList()
{
    if (TaskList?.Count > 0)
    {
        ShowTaskList();
    }
    else
    {
        Console.WriteLine("No hay tareas por realizar");
    }
}

void ShowTaskList()
{
    Console.WriteLine("----------------------------------------");

    //Tasks.ForEach( task=> Console.WriteLine(indexTask++ + ". " + task));

    for (int i = 0; i < TaskList.Count; i++)
    {
        Console.WriteLine((i + 1) + ". " + TaskList[i]);
    }
    Console.WriteLine("----------------------------------------");
}


public enum Menu
{
    Add = 1,
    Remove = 2,
    List = 3,
    Exit = 4
}

