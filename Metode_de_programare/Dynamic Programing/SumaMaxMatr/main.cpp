#include <iostream>
#include<cmath>
using namespace std;
/*
Se considera o matrice patr n x n
in care fiecare linie se vor afla i elem
Sa se det suma max care se poate obtine adunand cate un elem de pe fiecare linie
iar la fiecare elem de pe linia i col j se poate aduna
fie elem de pe linie i+1 col j, fie elem de pe lin i+1 col j+1

4
1 4
2 1 3
9 4 4 3
4 5 2 2 1

*/

int mat[101][101], suma[101][101], n;

int main()
{
    cin >> n;
    for(int i = 1; i <=n; i++){
        for(int j = 1; j <= i; j++)
            cin >> mat[i][j];
    }
    for(int j = 1; j<=n ; j++){
        suma[n][j] = mat[n][j];
    }
    for(int i = n-1; i>= 1; i--){
        for(int j = 1; j <=i; j++){
            suma[i][j] = mat[i][j] + max(suma[i+1][j], suma[i+1][j+1]);
        }
    }
    cout << suma[1][1];
    return 0;
}
