﻿using System.Collections;
using System.Collections.Generic;

public interface ICommand
{
    void Execute();
    void Undo();
}