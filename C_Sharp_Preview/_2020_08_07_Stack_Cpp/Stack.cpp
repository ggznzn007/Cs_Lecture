#include <iostream>

using namespace std;

struct Stack {
    // �ʼ������� �ʿ��� �������
    int data[1000]; // ������ ����    -> ���ڿ��� �����ϰ� ������ string Ÿ������ ������ ��, �Լ����� return ���� ���� �������ָ� �ȴ�.
    int size;       // ���� ������ ���� �ʿ���

    // ������ : ��������� �ʱ�ȭ�� ����Ѵ�. �̰��� �������� ������ ��� ��.
    Stack()
    {
        size = 0;
    }

    void push(int n)
    {
        data[size] = n;
        size += 1;
    }

    int pop()
    {
        if (size == 0)
            return -1;
        else {
            size -= 1;         // pop �� �� �����͸� ���� �������ִ� �۾��� ����.(�ٽ� push�� ����� �ǹǷ�)
            return data[size];
        }
    }

    bool empty()
    {
        return (size == 0) ? true : false;
    }

    int top()
    {
        return (size == 0) ? -1 : data[size - 1];
    }
};

int main(void)
{
    ios::sync_with_stdio(false);

    int N;
    Stack st; // ����ü Ÿ���� ���� ����

    cin >> N;

    while (N--) {
        string cmd;
        cin >> cmd;

        if (cmd == "push")
        {
            int a;
            cin >> a;
            st.push(a);
        }
        else if (cmd == "pop")
            cout << st.pop() << endl;

        else if (cmd == "size")
            cout << st.size << endl;

        else if (cmd == "empty")
            cout << st.empty() << endl;

        else if (cmd == "top")
            cout << st.top() << endl;
    }
}