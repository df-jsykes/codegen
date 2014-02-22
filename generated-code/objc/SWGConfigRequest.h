#import <Foundation/Foundation.h>
#import "NIKSwaggerObject.h"
#import "SWGHostInfo.h"
#import "Integer.h"

@interface SWGConfigRequest : NIKSwaggerObject

@property(nonatomic) NSNumber* open_reg_role_id;
@property(nonatomic) NSNumber* open_reg_email_service_id;
@property(nonatomic) NSNumber* open_reg_email_template_id;
@property(nonatomic) NSNumber* invite_email_service_id;
@property(nonatomic) NSNumber* invite_email_template_id;
@property(nonatomic) NSNumber* password_email_service_id;
@property(nonatomic) NSNumber* password_email_template_id;
@property(nonatomic) NSNumber* guest_role_id;
@property(nonatomic) NSString* editable_profile_fields;
@property(nonatomic) NSArray* allowed_hosts;
- (id) open_reg_role_id: (NSNumber*) open_reg_role_id
     open_reg_email_service_id: (NSNumber*) open_reg_email_service_id
     open_reg_email_template_id: (NSNumber*) open_reg_email_template_id
     invite_email_service_id: (NSNumber*) invite_email_service_id
     invite_email_template_id: (NSNumber*) invite_email_template_id
     password_email_service_id: (NSNumber*) password_email_service_id
     password_email_template_id: (NSNumber*) password_email_template_id
     guest_role_id: (NSNumber*) guest_role_id
     editable_profile_fields: (NSString*) editable_profile_fields
     allowed_hosts: (NSArray*) allowed_hosts;

- (id) initWithValues: (NSDictionary*)dict;
- (NSDictionary*) asDictionary;


@end

