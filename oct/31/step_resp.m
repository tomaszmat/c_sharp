function [y]=step_resp(b,a,N)

for n=0:N-1
  if n < 0
      x(n+1) = 0;
  else
      x(n+1) = 1;
  end
endfor

y = NOI_filter(b,a,x);

endfunction