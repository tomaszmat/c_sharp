clc
clear all
clear all
N=100
k=4
b=movavg_filter(6,k);
xxx=imp_resp(b,N);
PO = fir_filter(xxx,b);
subplot(2,3,1);
plot(PO)
title('odp. impulsowa')
x=step_resp(b,N);
PO = fir_filter(x,b);


subplot(2,3,2);
plot(PO)
title('odp. skokowa')
[mH,fH,mHdB]=freq_resp(b,N);
subplot(2,3,3);
plot(mH)
title('amplitudowa liniowa')
subplot(2,3,4);
plot(mHdB)
title('amplitudowa dB')
subplot(2,3,5);
plot(mHdB)
title('odpowiedz fazowa')

%fc=100
%wnd=1
%doln=sinc_filter(fc,xxx,wnd);
%subplot(2,3,6);
%plot(doln)
%title('dolnoprzep')

%b = [1 -2 5 2]; %filtr

