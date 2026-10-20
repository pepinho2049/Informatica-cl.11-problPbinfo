#include <iostream>
using namespace std;
/*
Se citesc n elem ale unui vector v
Sa se determine cel mai lung subsir cu elemente aflate in ordine cresc
.....
Se construiesc vectorii lg(care va memora lungimea celui mai lung subsir crescator care incepe de pe poz i)
si vect next(care va memora poz urmatorului elem din sirul cresc)
*/



int main()
{
    int v[1001], lg[1001], next[1001], n;
    cin >> n;
    for(int i=1; i<=n; i++){
        cin >> v[i];
        next[i] = -1;
        lg[i] = 1;
    }
    for(int i = n-1; i>=1; i--){
        for(int j = i+1; j <= n; j++){
            if(v[i] < v[j] && lg[i] <= lg[j]){
                lg[i] = lg[j] + 1;
                next[i] = j;
            }

        }
    }
    int maxi = -1, pmax;
    for(int i = 1; i <= n; i++){
        if(lg[i] > maxi){
            maxi = lg[i], pmax = i;
        }
    }
    cout << maxi << endl;
    while(pmax!= -1){
        cout << pmax << ' ';
        pmax = next[pmax];
    }

    return 0;
}
