#import <Foundation/Foundation.h>
#import "NIKSwaggerObject.h"
#import "SWGApp.h"
#import "Integer.h"

@interface SWGRoleRequest : NIKSwaggerObject

@property(nonatomic) NSNumber* _id;
@property(nonatomic) NSString* name;
@property(nonatomic) NSString* description;
@property(nonatomic) NSNumber* is_active;
@property(nonatomic) NSNumber* default_app_id;
@property(nonatomic) SWGApp* default_app;
@property(nonatomic) NSArray* users;
@property(nonatomic) NSArray* apps;
@property(nonatomic) NSArray* services;
- (id) _id: (NSNumber*) _id
     name: (NSString*) name
     description: (NSString*) description
     is_active: (NSNumber*) is_active
     default_app_id: (NSNumber*) default_app_id
     default_app: (SWGApp*) default_app
     users: (NSArray*) users
     apps: (NSArray*) apps
     services: (NSArray*) services;

- (id) initWithValues: (NSDictionary*)dict;
- (NSDictionary*) asDictionary;


@end

