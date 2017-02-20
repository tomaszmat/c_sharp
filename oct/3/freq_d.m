function [f]=freq_d(tN, N)
	for k=0:N-1
	f(k+1)=k*(N-1)/(N*tN);
	endfor
 endfunction