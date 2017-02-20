function fi=gj_arg(re,im)
N=length(re);
for i=1:N
if (re(i)>0 && im(i)>0)
fi(i)=atan(im(i)/re(i));
elseif (re(i)<0 && im(i)>=0)
fi(i)=pi+atan(im(i)/re(i));
elseif (re(i)==0 && im(i)>0)
fi(i)=pi/2;
elseif (re(i)<0 && im(i)<=0)
fi(i)=-pi+atan(im(i)/re(i));
elseif (re(i)>0 && im(i)<=0)
fi(i)=atan(im(i)/re(i));
else
fi(i)=-pi/2;
endif
endfor
endfunction