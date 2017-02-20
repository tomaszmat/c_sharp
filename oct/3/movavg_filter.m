function [b] = movavg_filter(M, k)

% M - ilosc usrednien
% k >=1 - wielokrotnosc filtracji

b = zeros(1, M);
  
for n = 1 : M
  b(n) = (1/M);
endfor

bconst = b ;
for h = 2 : k
  b = conv(b,bconst);
endfor





endfunction