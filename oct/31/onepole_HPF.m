function [a,b]=onepole_HPF(fc)
x=e^(-2*pi*fc);
b0=(1+x)/2;
b1=-(1+x)/2;
a0=1;
a1=-x;
a=[a1];
b=[b0,b1];
endfunction