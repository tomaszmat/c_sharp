function [y]=imp_resp(b,N)

for n=0:N-1
  if n == 0
      x(n+1) = 1;
  else
      x(n+1) = 0;
  end
endfor

y = fir_filter(x,b);

endfunction