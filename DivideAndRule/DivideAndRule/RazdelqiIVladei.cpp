#include<iostream>
using namespace std;
int max(int *a,int l, int r) {
	if (l == r) 
		return a[l];
	int m = (l + r) / 2;
	int u = max(a, l, m);
	int v = max(a, m + 1, r);
	if (u > v)
		return u;
	else
		return v;

	
}
const int N = 5;
void main() {
	int b[N];
	for (int i = 0; i < N; i++) {
		cout << "\n b[" << i << "]=";
		cin >> b[i];
	}
	cout << "\n Max= " << max(b, 0, N - 1);
}