function f=gj_freq(N,fs)
f=zeros(1,N);
for i=1:N
f(i)=(i-1)*fs/N;
endfor
endfunction