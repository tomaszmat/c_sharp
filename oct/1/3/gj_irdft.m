function x=gj_irdft(Re,Im)
N=(length(Re)-1)*2; 
Re(1)/=2; 
Im(1)/=2;
Re(N/2+1)/=2; 
Im(N/2+1)/=2; 
x=zeros(1,N);
for n=0:N-1
T=0;
for k=0:N/2
T+=Re(k+1)*cos(2*pi*n*k/N)-Im(k+1)*sin(2*pi*n*k/N);
endfor
x(n+1)=T;
endfor
endfunction