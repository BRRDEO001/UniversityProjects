"""
>>> import timeutil
>>> timeutil.validate("11.15 p.m. ")
False
>>> timeutil.validate("01:1 a.m. ")
False
>>> timeutil.validate("12:61 a.m. ")
False
>>> timeutil.validate("111:01 p.m. ")
False
>>> timeutil.validate("1:15 t. ")
False
>>> timeutil.validate("02:02p.m ")
False

"""
import doctest
doctest.testmod(verbose=True)


