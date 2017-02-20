function [y]=NOI_filter(b,a,x)
  N=numel(x);
  A=numel(a);
  B=numel(b);
   y=zeros(1,N);
   
  for n=1:N;
    for m=1:B;
      if (0>=m-n)
        y(n)+=b(m)*x(n-m+1);
      endif  
    endfor
  endfor  
    
    for n=1:N;
    for m=1:A;
      if (-1>=m-n)
        y(n)-=a(m)*y(n-m);
      endif  
    endfor
  endfor  
    
endfunction