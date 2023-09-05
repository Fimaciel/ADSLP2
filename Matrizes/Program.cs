

int[] a = { 12, 13, 14, 15, 16 };
int[] b = { 122, 10, 13, 16, 17 };

int[] c = new int [( 2 * a.Length )];

for ( int i = 0; i < a.Length; i++)
{
    c[i] = a[i];
   
}
bool tem;
int posit = a.Length;
for( int i = 0;i < b.Length; i++)
{
    for (int j = 0; j < b.Length; j++)
    {
        if (b[i] == a[j])
        {
            tem = true;
            break;
        }
        else
        {
            tem = false;
        }

        if (tem != true)
        {
            c[posit] = b[i];
            posit++;
        }
    }
    
}
for (int i= 0; i < c.Length; i++)
{
    Console.WriteLine(c[i]);
}