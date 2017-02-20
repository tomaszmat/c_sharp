function mag=gj_mag(re,im)
N=length(re);
mag=zeros(1,N);
for i=1:N
mag(i)=sqrt(re(i)*re(i)+im(i)*im(i));
endfor
endfunction