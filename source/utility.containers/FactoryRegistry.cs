﻿using System;

namespace code.utility.containers
{
  public class FactoryRegistry : IFindFactoriesForAType
  {
    public ICreateOneDependency get_factory_that_can_create(Type item_to_create)
    {
      throw new NotImplementedException();
    }
  }
}