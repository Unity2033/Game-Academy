#include <stdio.h>

void main()
{
#pragma region ���ǹ�
	// � ������ �־��� �� �ش� ���ǿ� ���� ������ 
	// �����ϵ��� �����ϴ� ��ɹ��Դϴ�.

#pragma region ���� ������
	// �� ���� �ǿ������� ���� ���Ͽ� �� ����� 0 �Ǵ�
	// 1�̶�� ������ ��Ÿ���� �������Դϴ�.

	// int positionX = 10;
	// int positionY = 20;
	// 
	// printf("positionX < positionY : %d\n" , positionX < positionY);
	// 
	// printf("positionX > positionY : %d\n" , positionX > positionY);
	// 
	// printf("positionX <= positionY : %d\n", positionX <= positionY);
	// 
	// printf("positionX >= positionY : %d\n", positionX >= positionY);
	// 
	// printf("positionX != positionY : %d\n", positionX != positionY);
	// 
	// printf("positionX == positionY : %d\n", positionX == positionY);

	// ���� �����ڴ� ������ ���� �� 1�̶�� ������ ��ȯ�Ǹ�,
	// ������ Ʋ�� �� 0�̶�� ������ ��ȯ�˴ϴ�.
#pragma endregion

#pragma region if��
	// � Ư���� ������ ���Ͽ� ������ �´ٸ� ����Ǵ�
	// ��ɹ��Դϴ�.

	//	int health = 0;
	//	
	//	if (health <= 0)
	//	{
	//		printf("Destroy");
	//	}

	// if���� ������ 1�� �� ����Ǹ�, 0�� �� ������� �ʽ��ϴ�.
#pragma endregion

#pragma region else if��
	// if���� ������ Ʋ�� �� else if���� ������
	// �´ٸ� ����Ǵ� ��ɹ��Դϴ�.

	//	int level = 99;
	//	
	//	if (level < 11)
	//	{
	//		printf("1 Circles");
	//	}
	//	else if (level >= 99)
	//	{
	//		printf("5 Circles");
	//	}

	// else if���� ������ ������ �� ������, if����
	// ������ �� ����� �� �ֽ��ϴ�. 
#pragma endregion

#pragma region else��
	// if���� else if���� ������ �� Ʋ����
	// ����Ǵ� ��ɹ��Դϴ�.

	//	int integer = 0;
	//	
	//	if (integer > 0)
	//	{
	//		printf("integer ������ ����Դϴ�.\n");
	//	}
	//	else if (integer < 0)
	//	{
	//		printf("integer ������ �����Դϴ�.\n");
	//	}
	//	else
	//	{
	//		printf("integer ������ ����� �ƴϰ�, ������ �ƴմϴ�.\n");
	//	}

	// if���� ����� ��� ���ǹ��� ������ ���� ��
	// ���� ���� �ִ� ���ǹ��� ����˴ϴ�.
#pragma endregion

#pragma region switch��
	// � ����� ���� �� ������� ����Ǵ� ��ɹ��Դϴ�.

	// char grade = 'G';
	// 
	// // switch���� �ش� ������ �Ϸ�Ǿ��� ��, break���� ������
	// // ������ �ؿ� �ִ� case ������ ��� �����Ű�ٰ� �����մϴ�.
	// 
	// switch (grade)
	// {
	// case 'A': printf("100�� ~ 90���Դϴ�.\n");
	// 	break;
	// case 'B': printf("89�� ~ 80���Դϴ�.\n");
	// 	break;
	// case 'C': printf("79�� ~ 70���Դϴ�.\n");
	// 	break;
	// case 'D': printf("69�� ~ 60���Դϴ�.\n");
	// 	break;
	// case 'F': printf("60�� �����Դϴ�.\n");
	// 	break;
	// default: printf("Exception");
	// 	break;
	// }

	// switch���� ��� ���ǿ� �ش��ϴ� ���� ���� ������
	// ��ġ�� �̵��մϴ�.
#pragma endregion

#pragma region �� ������

#pragma region AND ������
// �� ���� ������ �� ������ �� ����Ǵ� �������Դϴ�.

//	int score = 99;
//	char rank = 'A';
//	
//	if (score == 100 && rank == 'A')
//	{
//		printf("1st Place");
//	}  
#pragma endregion

#pragma region OR ������
// �� ���� ���� �߿��� �ϳ��� ������ ������ �� ����Ǵ� �������Դϴ�.

//	int weight = 70;
//	int bodyFat = 30;
//	
//	if (weight > 75 || bodyFat > 20)
//	{
//		printf("���Դϴ�.");
//	}
#pragma endregion

#pragma region NOT ������
// �ϳ��� ������ ������Ű�� �������Դϴ�.

//	int power = 0;
//	
//	if (!power)
//	{
//		printf("off");
//	}

#pragma endregion

#pragma endregion

#pragma region ��и�

//	int x = 0;
//	int y = 0;
//	
//	if (x > 0 && y > 0)
//	{
//		printf("�� 1 ��и�\n");
//	}
//	else if (x < 0 && y > 0)
//	{
//		printf("�� 2 ��и�\n");
//	}
//	else if (x < 0 && y < 0)
//	{
//		printf("�� 3 ��и�\n");
//	}
//	else if (x > 0 && y < 0)
//	{
//		printf("�� 4 ��и�\n");
//	}
//	else if (x != 0 && y == 0)
//	{
//		printf("X ����\n");
//	}
//	else if (x == 0 && y != 0)
//	{
//		printf("Y ����\n");
//	}
//	else
//	{
//		printf("����\n");
//	}


#pragma endregion

#pragma endregion

}
