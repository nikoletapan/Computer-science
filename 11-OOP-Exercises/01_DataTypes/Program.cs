// type, name, value

const int K = 5;

K = K + 2;

int a = 3;
int b = 4;

Console.WriteLine(a + b);

int s = a + b;

Console.WriteLine(s);

double d = 0.1;
double e = 0.2;

Console.WriteLine(d + e); // уязвимост в паметта при double

double f = 2.1;
double g = 0.3;

Console.WriteLine(f/g);  // още един пример - особено около 3

decimal d1 = 0.1M;
decimal e1 = 0.2M;

Console.WriteLine(d1 + e1); // при финанси Decimal!!!

