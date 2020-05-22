"use strict";
const Generator = require("yeoman-generator");
const chalk = require("chalk");
const yosay = require("yosay");

module.exports = class extends Generator {
  prompting() {
    this.log(yosay(`Welcome to the ${chalk.red("dotnetclean")} generator!`));

    const prompts = [
      {
        type: "input",
        name: "solution",
        message: "Solution name: ",
        default: "BaseCleanArchitecture"
      }
    ];

    return this.prompt(prompts).then(props => {
      this.props = props;
    });
  }

  writing() {
    this.fs.copyTpl(
      this.templatePath("BFC900.sln"),
      this.destinationPath(`${this.props.solution}.sln`),
      {
        solution: this.props.solution
      }
    );

    /// /////////////////////////////////Core Project////////////////////////////////////
    this.fs.copy(
      this.templatePath("BFC900.Core\\BFC900.Core.csproj"),
      this.destinationPath(
        `${this.props.solution}.Core\\${this.props.solution}.Core.csproj`
      )
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Core\\Domain\\Exceptions\\DomainLayerException.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Core\\Domain\\Exceptions\\DomainLayerException.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Core\\Domain\\Exceptions\\EntityValidationException.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Core\\Domain\\Exceptions\\EntityValidationException.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath("BFC900.Core\\Domain\\Entities\\BaseEntity.cs"),
      this.destinationPath(
        `${this.props.solution}.Core\\Domain\\Entities\\BaseEntity.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath("BFC900.Core\\Domain\\Entities\\IEntityIdentifier.cs"),
      this.destinationPath(
        `${this.props.solution}.Core\\Domain\\Entities\\IEntityIdentifier.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath("BFC900.Core\\Domain\\Entities\\User.cs"),
      this.destinationPath(
        `${this.props.solution}.Core\\Domain\\Entities\\User.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Core\\Application\\Shared\\Commands\\IExecutor.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Core\\Application\\Shared\\Commands\\IExecutor.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Core\\Application\\Shared\\Commands\\BaseCommand.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Core\\Application\\Shared\\Commands\\BaseCommand.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Core\\Application\\Shared\\Providers\\IDatabaseProvider.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Core\\Application\\Shared\\Providers\\IDatabaseProvider.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Core\\Application\\Shared\\Providers\\IRestServiceProvider.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Core\\Application\\Shared\\Providers\\IRestServiceProvider.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Core\\Application\\User\\Commands\\GetUserFromDbCommand.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Core\\Application\\User\\Commands\\GetUserFromDbCommand.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Core\\Application\\User\\Commands\\GetUserFromServiceCommand.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Core\\Application\\User\\Commands\\GetUserFromServiceCommand.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Core\\Application\\User\\Commands\\IGetUserCommand.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Core\\Application\\User\\Commands\\IGetUserCommand.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Core\\Application\\User\\Providers\\IUserDataProvider.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Core\\Application\\User\\Providers\\IUserDataProvider.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Core\\Application\\User\\Providers\\IUserServiceProvider.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Core\\Application\\User\\Providers\\IUserServiceProvider.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Core\\Application\\User\\Services\\IUserService.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Core\\Application\\User\\Services\\IUserService.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Core\\Application\\User\\Services\\UserService.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Core\\Application\\User\\Services\\UserService.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    /// /////////////////////////////////Infrastructure Project////////////////////////////////////

    this.fs.copyTpl(
      this.templatePath("BFC900.Infrastructure\\BFC900.Infrastructure.csproj"),
      this.destinationPath(
        `${this.props.solution}.Infrastructure\\${this.props.solution}.Infrastructure.csproj`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath("BFC900.Infrastructure\\Providers\\IUnitOfWork.cs"),
      this.destinationPath(
        `${this.props.solution}.Infrastructure\\Providers\\IUnitOfWork.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath("BFC900.Infrastructure\\Providers\\IRepository.cs"),
      this.destinationPath(
        `${this.props.solution}.Infrastructure\\Providers\\IRepository.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Infrastructure\\Providers\\EF\\EntityFrameworkDataProvider.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Infrastructure\\Providers\\EF\\IRepEntityFrameworkDataProviderository.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Infrastructure\\Providers\\EF\\Context\\AppDbContext.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Infrastructure\\Providers\\EF\\Context\\AppDbContext.cs`
      ),
      {
        solution: this.props.solution
      }
    );

    this.fs.copyTpl(
      this.templatePath(
        "BFC900.Infrastructure\\Providers\\EF\\Entities\\SUser.cs"
      ),
      this.destinationPath(
        `${this.props.solution}.Infrastructure\\Providers\\EF\\Entities\\SUser.cs`
      ),
      {
        solution: this.props.solution
      }
    );
  }
};
