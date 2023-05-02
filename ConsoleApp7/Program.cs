#include <iostream>
using namespace std;
#define size 5
int stack[size], top = -1;

void push(int value);
int pop();
int peek();
void display();

int main()
{
    push(5);
    push(15);
    push(25);
    push(35);
    display();
    cout << "\n===\n";
    pop();
    display();
    cout << "\n===\n";
    cout << "peek is " << peek() << endl;
    display();
    return 0;
}

void push(int value)
{
    if (top == size - 1)
    {
        cout << "Stack is full" << endl;
    }
    else
    {
        top++;
        stack[top] = value;
    }
}

int pop()
{
    if (top == -1)
    {
        cout << "Stack is empty" << endl;
    }
    else
    {
        return stack[top--];
    }
}

int peek()
{
    if (top == -1)
    {
        cout << "Stack is empty" << endl;
    }
    else
    {
        return stack[top];
    }
}

void display()
{
    if (top == -1)
    {
        cout << "Stack is empty" << endl;
    }
    else
    {
        for (int i = top; i >= 0; i--)
        {
            cout << stack[i] << endl;
        }
    }
}
