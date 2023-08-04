// Запрос целого числа у пользователя из консоли
int ask_for_int_number(string message)
{
	Console.Write(message);
	int number = int.Parse(Console.ReadLine());
	return number;
}

// Запрос у пользователя массива строк размером size
string[] input_string_array(int size)
{
	string[] array = new string[size];
	Console.WriteLine();
	Console.WriteLine("Enter string array elements:");
	Console.WriteLine();

	for (int index = 0; index < size; index++)
	{
		Console.Write($"Enter element number {index + 1}: ");
		array[index] = Console.ReadLine();
		Console.WriteLine();
	}
	return array;
}

// Исключение из исходного массива строк, размер которых больше word_size 
string[] filter_string_arr(string[] array, int word_size)
{
	int arr_size = array.Length;
	int correct_elements_number = 0;

	for (int index = 0; index < arr_size; index++)
	{
		if (array[index].Length <= word_size) correct_elements_number++ ; 
	}

	string[] result_array = new string[correct_elements_number];
	int second_index = 0;

	for (int index = 0; index < arr_size; index++)
	{
		if (array[index].Length <= word_size) 
		{
			result_array[second_index] = array[index]; 
			second_index++;
		}
	}
	return result_array;
}

int arr_size = ask_for_int_number("Enter array_size: ");
string[] inputed_str_arr = input_string_array(arr_size);

int word_size = 3;
string[] filtered_string_arr = filter_string_arr(inputed_str_arr, word_size);

Console.WriteLine("result: ");
Console.WriteLine("[" + String.Join(", ", filtered_string_arr) + "]");