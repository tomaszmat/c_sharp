function [Re,Im]=gj_rdft(x)
N=length(x); 
Re=zeros(1,N/2+1); 
Im=zeros(1,N/2+1);
for k=0:N/2
Tr=0;
Ti=0;
for n=0:N-1
Tr+=2*x(n+1)*cos(2*pi*k*n/N)/N;
Ti+=-2*x(n+1)*sin(2*pi*k*n/N)/N;
endfor
Re(k+1)=Tr;
Im(k+1)=Ti;
endfor
endfunction