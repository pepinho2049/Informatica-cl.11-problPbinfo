#include <bits/stdc++.h>
using namespace std;

ifstream fin("bac.in");

int main(){
    int x, y, a, b, cate=0, nr=0, ultim=0;
    fin>>x>>y;
    while(fin>>a>>b){
            nr++;
        if(max(a, x) < min(b, y)){
            cate++;
            ultim=nr;
        }
    }
    cout<<cate<<" "<<ultim;
}
