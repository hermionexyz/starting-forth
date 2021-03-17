def star(): print('*', end='')

def stars(n):
    for _ in range(n): star()

def margin(): print('\n' + ' ' * 30, end='')

def blip():
    margin()
    star()

def bar():
    margin()
    stars(5)

def f():
    bar()
    blip()
    bar()
    blip()
    blip()
    print()

f()
