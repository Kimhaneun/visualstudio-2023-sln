// [��ó���� ������]
// #���� ����

// #include<iostream>: ��� ���� iostream�� �ҽ��ڵ忡 ���Խ�Ű�� ����
// #define PI 3.14: PI�� ���������� 3.14�� ��ü�ϵ��� �����ϴ� ����
#include<iostream> 
#include <string>
#include <vector>

using namespace std;

int main()
{
	char arr[100];
	cout << "����� �̸���?" << endl; // endl: �ٹٲ�
	cin >> arr;
	cout << "�ȳ� " << " " << arr;
}

string Change(string str)
{
	for (int i = 0; i < str.length(); i++)
	{
		if (str[i] == 'o')
			str[i] = 'x';
	}
	return str;
}

// *����* - ���� �ϴ� �Ǽ�
// string str;
// str[3] = 'c'; �� �ۼ��ϰ� str ��½� string subscript out of range ���� �߻�
// ��? [3]�� ���� ����Ʈ �ǹ��� ��鰳 �����Ŵ�? ��� ���踸 �Ѱǵ�
// �� �� ����Ʈ 3�� ������ �ϴ°Ͱ� ���� ������

int solution(string my_string)
{
	int n = 0, answer = 0;

	for (int i = 0; i < my_string.length(); i++)
	{
		if (isdigit(my_string[i]))
			n = n * 10 + (my_string[i] - '0');
		else
		{
			answer += n;
			n = 0;
		}
	}
	return answer;
}

// my_string[i] >='0' && my_string[i] <='9'