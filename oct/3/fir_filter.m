function [y] = fir_filter(x, b)

	s = length(b)-1;
  tx=[zeros(1,s) x];
  
	for i = 1 : length(x)
   t = 0;
		for j = 1 : length(b)
			  t += b(j)*tx(s+i-j+1);
		endfor
    y(i)=t;
	endfor
  
endfunction
