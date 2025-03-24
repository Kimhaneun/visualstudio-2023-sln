// [전처리기 지시자]
// #으로 시작

// #include<iostream>: 헤더 파일 iostream를 소스코드에 삽입시키는 역할
// #define PI 3.14: PI를 만날때마다 3.14로 대체하도록 지시하는 역할
#include<iostream> 
#include <string>
#include <vector>

using namespace std;

int main()
{
	char arr[100];
	cout << "당신의 이름은?" << endl; // endl: 줄바꿈
	cin >> arr;
	cout << "안녕 " << " " << arr;
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

// *주의* - 많이 하는 실수
// string str;
// str[3] = 'c'; 를 작성하고 str 출력시 string subscript out of range 에러 발생
// 왜? [3]은 지금 아파트 건물을 몇백개 지을거다? 라고 설계만 한건데
// 아 저 아파트 3층 갈래요 하는것과 같기 때문에

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