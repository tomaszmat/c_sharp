function [a,b]=onepole_LPF(fc)
x=e^(-2*pi*fc);
b0=1-x;
a0=1;
a1=-x;
a=[a1];
b=[b0];
endfunction