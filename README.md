# Assembler
Basic assembler using C#, has branching/labels, input/out and 1000 memory slots for ints

# Example code [Multiply 2 numbers]:
```
INP
MOV ACC %1
INP
MOV ACC %3
MOV ACC %4
LOOP
BEZ END
SUB 1
MOV ACC %4
MOV %2 ACC
ADD %1
MOV ACC %2
MOV %4 ACC
BRA LOOP
END
OUT %2
```
