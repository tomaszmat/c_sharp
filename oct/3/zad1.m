N=100
k=4
fx = freq_d(N-1,N)
b=movavg_filter(6,k);

xxx=imp_resp(b,N);
PO = fir_filter(xxx,b);
subplot(2,3,1);
plot(PO)